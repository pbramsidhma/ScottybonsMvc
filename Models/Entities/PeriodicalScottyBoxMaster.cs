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
    
    public partial class PeriodicalScottyBoxMaster
    {
        public PeriodicalScottyBoxMaster()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int PeriodicalScottyBoxID { get; set; }
        public string PeriodicalScottyBox { get; set; }
        public Nullable<bool> Active { get; set; }
        public int DisplayOrder { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> PerodicalMonths { get; set; }
        public string Language { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
