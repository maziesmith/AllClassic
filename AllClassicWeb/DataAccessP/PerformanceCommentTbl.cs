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
    
    public partial class PerformanceCommentTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PerformanceCommentTbl()
        {
            this.PerformanceCommentTbl1 = new HashSet<PerformanceCommentTbl>();
        }
    
        public int CommentID { get; set; }
        public Nullable<int> PerformanceID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string CommentMessage { get; set; }
        public System.DateTime CommentDate { get; set; }
        public Nullable<int> ParentCommentID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceCommentTbl> PerformanceCommentTbl1 { get; set; }
        public virtual PerformanceCommentTbl PerformanceCommentTbl2 { get; set; }
        public virtual PerformanceTbl PerformanceTbl { get; set; }
        public virtual UserTbl UserTbl { get; set; }
    }
}
