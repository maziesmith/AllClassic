//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class LookUpTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LookUpTbl()
        {
            this.VenueTbls = new HashSet<VenueTbl>();
            this.PerformanceGroupTbls = new HashSet<PerformanceGroupTbl>();
            this.PerformanceTbls = new HashSet<PerformanceTbl>();
            this.PerformanceTbls1 = new HashSet<PerformanceTbl>();
            this.PerformanceGroupTbls1 = new HashSet<PerformanceGroupTbl>();
            this.PerformanceTbls2 = new HashSet<PerformanceTbl>();
        }
    
        public int LookUpID { get; set; }
        public string MainCode { get; set; }
        public string SubCode { get; set; }
        public Nullable<bool> TableLink { get; set; }
        public string Note { get; set; }
        public Nullable<int> UserID { get; set; }
        public System.DateTime UpdateTimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VenueTbl> VenueTbls { get; set; }
        public virtual UserTbl UserTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceGroupTbl> PerformanceGroupTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceTbl> PerformanceTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceTbl> PerformanceTbls1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceGroupTbl> PerformanceGroupTbls1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceTbl> PerformanceTbls2 { get; set; }
    }
}
