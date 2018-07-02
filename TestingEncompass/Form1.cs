using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EllieMae.Encompass.BusinessObjects.Loans;
using EllieMae.Encompass.Client;
using EllieMae.Encompass.Collections;
using EllieMae.Encompass.Query;
using EllieMae.Encompass.Reporting;
using TestingEncompass.Properties;

namespace TestingEncompass
{
    public partial class Form1 : Form
    {
        List<EncompassFieldDescriptor> _encompassFields = new List<EncompassFieldDescriptor>();

        public Form1()
        {
            InitializeComponent();
            Closing += Form1_Closing;
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var session = new Session();
            session.Start(dfsServerAddress.Text, dfsUserName.Text, dfsPassword.Text);
            var fields = session.Reports.GetReportingDatabaseFields().ToArray().ToList();
            _encompassFields = SortFields(fields);
            grdFields.DataSource = _encompassFields;
            lblTotalFields.Text = "Displayed Fields: " + _encompassFields.Count;
            AdjustGridColumnWidth();
        }

        private void AdjustGridColumnWidth()
        {
            foreach (DataGridViewColumn grdFieldsColumn in grdFields.Columns)
            {
                grdFieldsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private List<EncompassFieldDescriptor> SortFields(List<ReportingFieldDescriptor> input)
        {
            var numericFields = input.ToArray().Where(x => Regex.IsMatch(x.FieldID, @"^\d+$"))
                .OrderBy(a => int.Parse(a.FieldID)).ToList();
            var stringFields = input.ToArray().Where(x => !Regex.IsMatch(x.FieldID, @"^\d+$"))
                .OrderBy(h => h.FieldID)
                .ToList();
            numericFields.AddRange(stringFields);
            var output = new List<EncompassFieldDescriptor>();
            foreach (var fld in numericFields)
            {
                output.Add(new EncompassFieldDescriptor
                {
                    Auditable = fld.Auditable,
                    FieldID = fld.FieldID,
                    CanonicalName = fld.CanonicalName,
                    TableName = fld.CanonicalName,
                    FieldType = fld.FieldType,
                    Description = fld.Description,
                    ColumnName = fld.ColumnName,
                    FieldSize = fld.FieldSize,
                    BorrowerPair = fld.BorrowerPair,
                });
            }
            return output;
        }

        private List<EncompassFieldDescriptor> SortFields(List<EncompassFieldDescriptor> input)
        {
            var numericFields = input.ToArray().Where(x => Regex.IsMatch(x.FieldID, @"^\d+$"))
                .OrderBy(a => int.Parse(a.FieldID)).ToList();
            var stringFields = input.ToArray().Where(x => !Regex.IsMatch(x.FieldID, @"^\d+$"))
                .OrderBy(h => h.FieldID)
                .ToList();
            numericFields.AddRange(stringFields);

            return numericFields;
        }

        private void dfsSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnGetActualField.Enabled = false;
            if (encompassLoan == null)
            {
                var session = new Session();
                session.Start(dfsServerAddress.Text, dfsUserName.Text, dfsPassword.Text);

                var loanNumberCriterion =
                    new StringFieldCriterion {FieldName = "Loan.LoanNumber", Value = dfsLoanNumber.Text};

                var queryCriterionLoanFolder = new StringFieldCriterion
                {
                    FieldName = "Loan.LoanFolder",
                    Value = "(Trash)",
                    MatchType = StringFieldMatchType.Exact,
                    Include = false
                };

                var queryCriterion = loanNumberCriterion.And(queryCriterionLoanFolder);

                using (var pipelineCursor = session.Loans.QueryPipeline(queryCriterion, PipelineSortOrder.None))
                {
                    //  Check cursor
                    if (pipelineCursor == null)
                        throw new InvalidOperationException(
                            $"Pipeline query yielded no results (loan number: '{dfsLoanNumber.Text}').");

                    //  Check pipeline data
                    if (pipelineCursor.Count == 0)
                    {
                        pipelineCursor.Close();
                        throw new InvalidOperationException(
                            $"Pipeline cursor does not contain any data (loan number: '{dfsLoanNumber.Text}').");
                    }
                    var data = pipelineCursor.GetItem(0);
                    if (data == null)
                    {
                        pipelineCursor.Close();
                        throw new InvalidOperationException(
                            $"Pipeline data from cursor is null (loan number: '{dfsLoanNumber.Text}').");
                    }

                    //  Open loan
                    var loanName = data.LoanIdentity.LoanName;
                    pipelineCursor.Close();
                    if (string.IsNullOrWhiteSpace(loanName))
                        throw new InvalidOperationException(
                            $"Loan name retrieved from pipeline data is null or empty (loan number: '{dfsLoanNumber.Text}').");

                    encompassLoan = session.Loans.Folders[data.LoanIdentity.LoanFolder].OpenLoan(loanName);
                }
            }
            btnGetActualField.Enabled = true;
            try
            {
                var field = encompassLoan.Fields[dfsFieldId.Text];

                var encompassField = new EncompassFieldDescriptor
                {
                    FieldID = field.ID,
                    ReadOnly = field.ReadOnly,
                    Description = field.Descriptor.Description,
                    Format = field.Descriptor.Format.ToString(),
                };

                actualFields.Add(encompassField);
                grdFields.DataSource = null;
                grdFields.DataSource = actualFields;
                AdjustGridColumnWidth();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            
        }
        private List<EncompassFieldDescriptor> actualFields = new List<EncompassFieldDescriptor>(); 
        private Loan encompassLoan = null;
        private void dfsSearch_Leave(object sender, EventArgs e)
        {
            var searchFields = _encompassFields.Where(x => x.FieldID.Contains(dfsSearch.Text) ||
                                                            (!string.IsNullOrEmpty(x.CanonicalName) &&  x.CanonicalName.ToLower()
                                                               .Contains(dfsSearch.Text.ToLower())) ||
                                                           (!string.IsNullOrEmpty(x.Description) && x.Description.ToLower().Contains(dfsSearch.Text.ToLower())) ||
                                                            (!string.IsNullOrEmpty(x.FieldType) && x.FieldType.ToLower().Contains(dfsSearch.Text.ToLower())) ||
                                                             (!string.IsNullOrEmpty(x.TableName) && x.TableName.ToLower().Contains(dfsSearch.Text.ToLower())) ||
                                                              (!string.IsNullOrEmpty(x.ColumnName) && x.ColumnName.ToLower().Contains(dfsSearch.Text.ToLower()))
            ).ToList();
            grdFields.DataSource = searchFields;
            lblTotalFields.Text = "Displayed Fields: " + searchFields.Count;
            AdjustGridColumnWidth();
        }
    }
}