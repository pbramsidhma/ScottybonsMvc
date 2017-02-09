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
    
    public partial class CountryMaster
    {
        public CountryMaster()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string TwoLetterISOCode { get; set; }
        public string TwoLetterLanguageCode { get; set; }
        public string ThreeLetterISOCode { get; set; }
        public string NumericISOCode { get; set; }
        public Nullable<byte> Published { get; set; }
        public int DisplayOrder { get; set; }
        public string ExtensionData { get; set; }
        public Nullable<int> VATPercentage1 { get; set; }
        public Nullable<int> VATPercentage2 { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string LanguageName { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
