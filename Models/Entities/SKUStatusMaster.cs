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
    
    public partial class SKUStatusMaster
    {
        public SKUStatusMaster()
        {
            this.ArticleSKUs = new HashSet<ArticleSKU>();
        }
    
        public int SKUStatusID { get; set; }
        public string SKUStatusName { get; set; }
        public Nullable<bool> Active { get; set; }
        public int DisplayOrder { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual ICollection<ArticleSKU> ArticleSKUs { get; set; }
    }
}