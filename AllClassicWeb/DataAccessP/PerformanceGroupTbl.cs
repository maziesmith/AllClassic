//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessP
{
    using System;
    using System.Collections.Generic;
    
    public partial class PerformanceGroupTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PerformanceGroupTbl()
        {
            this.PerformanceTbls = new HashSet<PerformanceTbl>();
        }
    
        public int PerformanceGroupID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public Nullable<int> GroupType { get; set; }
        public Nullable<int> City { get; set; }
        public string Conductor { get; set; }
        public string SinceYear { get; set; }
        public string EmailID { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string Facebook { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string HomePage { get; set; }
        public Nullable<int> UserID { get; set; }
        public System.DateTime UpdateTimeStamp { get; set; }
    
        public virtual LookUpTbl LookUpTbl { get; set; }
        public virtual LookUpTbl LookUpTbl1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceTbl> PerformanceTbls { get; set; }
        public virtual UserTbl UserTbl { get; set; }
    }
}