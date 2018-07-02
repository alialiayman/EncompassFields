using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEncompass
{
    public class EncompassFieldDescriptor
    {

        //
        // Summary:
        //     Gets the Field ID for the field.
        public string FieldID { get; set; }


        //
        // Summary:
        //     Gets the Description for the field.
        public string Description { get; set; }
        //
        // Summary:
        //     Get the FieldType for the field.
        public string FieldType { get; set; }

        //
        // Summary:
        //     Gets the FieldSize for the field.
        public int FieldSize { get; set; }

        //
        // Summary:
        //     Returns the name of the underlying SQL table that stores this field
        public string TableName { get; set; }

        //
        // Summary:
        //     Returns the name of the column in the SQL table in which this data is stored.
        public string ColumnName { get; set; }

        //
        // Summary:
        //     Indicates if the Audit Trail is enabled for this field.
        public bool Auditable { get; set; }
        //
        // Summary:
        //     Returns the Borrower Pair index for the field.
        public int BorrowerPair { get; set; }

        //
        // Summary:
        //     Returns the canonical name of the field to be used in queries.
        public string CanonicalName { get; set; }

        public bool ReadOnly { get; set; }
        public string Format { get; set; }


    }
}
