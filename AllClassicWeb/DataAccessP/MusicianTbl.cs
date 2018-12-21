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
    
    public partial class MusicianTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MusicianTbl()
        {
            this.MusicianEndorserTbls = new HashSet<MusicianEndorserTbl>();
            this.PerformanceTbls = new HashSet<PerformanceTbl>();
            this.PerformanceTbls1 = new HashSet<PerformanceTbl>();
            this.PerformanceMusicianInstrumentTbls = new HashSet<PerformanceMusicianInstrumentTbl>();
        }
    
        public int MusicianID { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string KakaoTalk { get; set; }
        public string Affliation { get; set; }
        public Nullable<int> Major1 { get; set; }
        public Nullable<int> Major2 { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Profile { get; set; }
        public string Repertory { get; set; }
        public Nullable<int> UserID { get; set; }
        public System.DateTime UpdateTimeStamp { get; set; }
        public int Major { get; set; }
    
        public virtual InstrumentTbl InstrumentTbl { get; set; }
        public virtual InstrumentTbl InstrumentTbl1 { get; set; }
        public virtual LookUpTbl LookUpTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusicianEndorserTbl> MusicianEndorserTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceTbl> PerformanceTbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceTbl> PerformanceTbls1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceMusicianInstrumentTbl> PerformanceMusicianInstrumentTbls { get; set; }
        public virtual UserTbl UserTbl { get; set; }
    }
}
