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
    
    public partial class UserTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserTbl()
        {
            this.InstrumentTbls = new HashSet<InstrumentTbl>();
            this.VenueTbls = new HashSet<VenueTbl>();
            this.LookUpTbls = new HashSet<LookUpTbl>();
            this.PerformanceGroupTbls = new HashSet<PerformanceGroupTbl>();
            this.PerformanceTbls = new HashSet<PerformanceTbl>();
            this.UserUserTypes = new HashSet<UserUserType>();
            this.MusicianTbls = new HashSet<MusicianTbl>();
            this.CollegeTbls = new HashSet<CollegeTbl>();
            this.ArticleTbls = new HashSet<ArticleTbl>();
            this.AuditionTbls = new HashSet<AuditionTbl>();
            this.ConcourTbls = new HashSet<ConcourTbl>();
            this.RepairShopTbls = new HashSet<RepairShopTbl>();
            this.MusicShopTbls = new HashSet<MusicShopTbl>();
            this.PeopleAndJobTbls = new HashSet<PeopleAndJobTbl>();
            this.PerformanceCommentTbls = new HashSet<PerformanceCommentTbl>();
            this.PerformanceLikeUnlikeTbls = new HashSet<PerformanceLikeUnlikeTbl>();
            this.AnswersTbls = new HashSet<AnswersTbl>();
            this.QuestionsTbls = new HashSet<QuestionsTbl>();
        }
    
        public int UserID { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public string MobileNo { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string KakaoTalk { get; set; }
        public string OtherSNS { get; set; }
        public string Affliation { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string PosterEmailID { get; set; }
        public System.DateTime UpdateTimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstrumentTbl> InstrumentTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VenueTbl> VenueTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LookUpTbl> LookUpTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceGroupTbl> PerformanceGroupTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceTbl> PerformanceTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserUserType> UserUserTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusicianTbl> MusicianTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollegeTbl> CollegeTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleTbl> ArticleTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditionTbl> AuditionTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConcourTbl> ConcourTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RepairShopTbl> RepairShopTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusicShopTbl> MusicShopTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PeopleAndJobTbl> PeopleAndJobTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceCommentTbl> PerformanceCommentTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceLikeUnlikeTbl> PerformanceLikeUnlikeTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnswersTbl> AnswersTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionsTbl> QuestionsTbls { get; set; }
    }
}
