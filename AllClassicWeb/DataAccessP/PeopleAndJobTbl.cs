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
    
    public partial class PeopleAndJobTbl
    {
        public int PeopleAndJobID { get; set; }
        public string PeopleOrJob { get; set; }
        public Nullable<System.DateTime> ValidDate { get; set; }
        public Nullable<int> City { get; set; }
        public string Title { get; set; }
        public string ContactName { get; set; }
        public string TelNo { get; set; }
        public string EmailID { get; set; }
        public string Description { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> UpdateTimeStamp { get; set; }
    
        public virtual UserTbl UserTbl { get; set; }
        public virtual LookUpTbl LookUpTbl { get; set; }
    }
}
