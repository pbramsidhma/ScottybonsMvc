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
    
    public partial class SubCategoryProperty
    {
        public SubCategoryProperty()
        {
            this.Articles = new HashSet<Article>();
        }
    
        public int SubCategoryPropertyID { get; set; }
        public int SubCategoryName { get; set; }
        public Nullable<int> SubCategoryID { get; set; }
        public Nullable<int> MaterialID { get; set; }
        public Nullable<int> FitID { get; set; }
        public Nullable<int> ComfortID { get; set; }
        public Nullable<int> FigureID { get; set; }
        public Nullable<int> PantsWaistID { get; set; }
        public Nullable<int> PantsModelID { get; set; }
        public Nullable<int> PantsLengthID { get; set; }
        public Nullable<int> SkirtWidthID { get; set; }
        public Nullable<int> SkirtLengthID { get; set; }
        public Nullable<int> SleeveLengthID { get; set; }
        public Nullable<int> WaistFitID { get; set; }
        public Nullable<int> ColarTypeID { get; set; }
        public Nullable<int> FootWidthID { get; set; }
        public Nullable<int> ShoeMaterialID { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ColarTypeMaster ColarTypeMaster { get; set; }
        public virtual ComfortMaster ComfortMaster { get; set; }
        public virtual FigureMaster FigureMaster { get; set; }
        public virtual FitMaster FitMaster { get; set; }
        public virtual FootWidthMaster FootWidthMaster { get; set; }
        public virtual MaterialMaster MaterialMaster { get; set; }
        public virtual PantsLengthMaster PantsLengthMaster { get; set; }
        public virtual PantsModelMaster PantsModelMaster { get; set; }
        public virtual PantsWaistMaster PantsWaistMaster { get; set; }
        public virtual ShoeMaterialMaster ShoeMaterialMaster { get; set; }
        public virtual SkirtLengthMaster SkirtLengthMaster { get; set; }
        public virtual SkirtWidthMaster SkirtWidthMaster { get; set; }
        public virtual SleeveLengthMaster SleeveLengthMaster { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual WaistFitMaster WaistFitMaster { get; set; }
    }
}
