//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScottybonsMVC.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class History
    {
        public int ModifiedUserID { get; set; }
        public string ModifiedDate { get; set; }
        public string TableName { get; set; }
        public string RecordId { get; set; }
        public Nullable<System.DateTime> OldValue { get; set; }
        public Nullable<System.DateTime> NewValue { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}
