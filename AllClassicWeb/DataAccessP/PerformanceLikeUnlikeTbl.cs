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
    
    public partial class PerformanceLikeUnlikeTbl
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> PerformanceID { get; set; }
        public Nullable<System.DateTime> timestamp { get; set; }
        public Nullable<int> islike { get; set; }
    
        public virtual PerformanceTbl PerformanceTbl { get; set; }
        public virtual UserTbl UserTbl { get; set; }
    }
}