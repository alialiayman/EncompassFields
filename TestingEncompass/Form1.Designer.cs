namespace TestingEncompass
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetReportingFields = new System.Windows.Forms.Button();
            this.grdFields = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetActualField = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dfsSearch = new System.Windows.Forms.TextBox();
            this.dfsFieldId = new System.Windows.Forms.TextBox();
            this.dfsLoanNumber = new System.Windows.Forms.TextBox();
            this.dfsPassword = new System.Windows.Forms.TextBox();
            this.dfsUserName = new System.Windows.Forms.TextBox();
            this.dfsServerAddress = new System.Windows.Forms.TextBox();
            this.lblTotalFields = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetReportingFields
            // 
            this.btnGetReportingFields.Location = new System.Drawing.Point(866, 10);
            this.btnGetReportingFields.Name = "btnGetReportingFields";
            this.btnGetReportingFields.Size = new System.Drawing.Size(222, 23);
            this.btnGetReportingFields.TabIndex = 0;
            this.btnGetReportingFields.Text = "Get Reporting Fields";
            this.btnGetReportingFields.UseVisualStyleBackColor = true;
            this.btnGetReportingFields.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdFields
            // 
            this.grdFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFields.Location = new System.Drawing.Point(12, 68);
            this.grdFields.Name = "grdFields";
            this.grdFields.Size = new System.Drawing.Size(1412, 601);
            this.grdFields.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loan Number";
            // 
            // btnGetActualField
            // 
            this.btnGetActualField.Location = new System.Drawing.Point(866, 39);
            this.btnGetActualField.Name = "btnGetActualField";
            this.btnGetActualField.Size = new System.Drawing.Size(222, 23);
            this.btnGetActualField.TabIndex = 10;
            this.btnGetActualField.Text = "Get Actual Field";
            this.btnGetActualField.UseVisualStyleBackColor = true;
            this.btnGetActualField.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Field Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1120, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Search";
            // 
            // dfsSearch
            // 
            this.dfsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestingEncompass.Properties.Settings.Default, "dfsSearch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsSearch.Location = new System.Drawing.Point(1188, 36);
            this.dfsSearch.Name = "dfsSearch";
            this.dfsSearch.Size = new System.Drawing.Size(236, 20);
            this.dfsSearch.TabIndex = 13;
            this.dfsSearch.Text = global::TestingEncompass.Properties.Settings.Default.dfsSearch;
            this.dfsSearch.Leave += new System.EventHandler(this.dfsSearch_Leave);
            // 
            // dfsFieldId
            // 
            this.dfsFieldId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestingEncompass.Properties.Settings.Default, "dfsFieldId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsFieldId.Location = new System.Drawing.Point(520, 36);
            this.dfsFieldId.Name = "dfsFieldId";
            this.dfsFieldId.Size = new System.Drawing.Size(107, 20);
            this.dfsFieldId.TabIndex = 11;
            this.dfsFieldId.Text = global::TestingEncompass.Properties.Settings.Default.dfsFieldId;
            // 
            // dfsLoanNumber
            // 
            this.dfsLoanNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestingEncompass.Properties.Settings.Default, "dfsLoanNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsLoanNumber.Location = new System.Drawing.Point(98, 36);
            this.dfsLoanNumber.Name = "dfsLoanNumber";
            this.dfsLoanNumber.Size = new System.Drawing.Size(324, 20);
            this.dfsLoanNumber.TabIndex = 8;
            this.dfsLoanNumber.Text = global::TestingEncompass.Properties.Settings.Default.dfsLoanNumber;
            // 
            // dfsPassword
            // 
            this.dfsPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestingEncompass.Properties.Settings.Default, "dfsPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsPassword.Location = new System.Drawing.Point(727, 10);
            this.dfsPassword.Name = "dfsPassword";
            this.dfsPassword.PasswordChar = '*';
            this.dfsPassword.Size = new System.Drawing.Size(107, 20);
            this.dfsPassword.TabIndex = 6;
            this.dfsPassword.Text = global::TestingEncompass.Properties.Settings.Default.dfsPassword;
            // 
            // dfsUserName
            // 
            this.dfsUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestingEncompass.Properties.Settings.Default, "dfsUserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsUserName.Location = new System.Drawing.Point(520, 10);
            this.dfsUserName.Name = "dfsUserName";
            this.dfsUserName.Size = new System.Drawing.Size(107, 20);
            this.dfsUserName.TabIndex = 4;
            this.dfsUserName.Text = global::TestingEncompass.Properties.Settings.Default.dfsUserName;
            // 
            // dfsServerAddress
            // 
            this.dfsServerAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestingEncompass.Properties.Settings.Default, "dfsServerAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsServerAddress.Location = new System.Drawing.Point(98, 10);
            this.dfsServerAddress.Name = "dfsServerAddress";
            this.dfsServerAddress.Size = new System.Drawing.Size(324, 20);
            this.dfsServerAddress.TabIndex = 2;
            this.dfsServerAddress.Text = global::TestingEncompass.Properties.Settings.Default.dfsServerAddress;
            // 
            // lblTotalFields
            // 
            this.lblTotalFields.AutoSize = true;
            this.lblTotalFields.Location = new System.Drawing.Point(1185, 9);
            this.lblTotalFields.Name = "lblTotalFields";
            this.lblTotalFields.Size = new System.Drawing.Size(83, 13);
            this.lblTotalFields.TabIndex = 15;
            this.lblTotalFields.Text = "Displayed Fields";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 681);
            this.Controls.Add(this.lblTotalFields);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dfsSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dfsFieldId);
            this.Controls.Add(this.btnGetActualField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dfsLoanNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dfsPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dfsUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dfsServerAddress);
            this.Controls.Add(this.grdFields);
            this.Controls.Add(this.btnGetReportingFields);
            this.Name = "Form1";
            this.Text = "Encompass Fields";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetReportingFields;
        private System.Windows.Forms.DataGridView grdFields;
        private System.Windows.Forms.TextBox dfsServerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dfsUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dfsPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dfsLoanNumber;
        private System.Windows.Forms.Button btnGetActualField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dfsFieldId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dfsSearch;
        private System.Windows.Forms.Label lblTotalFields;
    }
}

