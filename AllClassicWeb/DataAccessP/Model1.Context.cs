﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AllClassicDBEntities : DbContext
    {
        public AllClassicDBEntities()
            : base("name=AllClassicDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnswersTbl> AnswersTbls { get; set; }
        public virtual DbSet<ArticleTbl> ArticleTbls { get; set; }
        public virtual DbSet<AuditionTbl> AuditionTbls { get; set; }
        public virtual DbSet<ConcourTbl> ConcourTbls { get; set; }
        public virtual DbSet<InstrumentTbl> InstrumentTbls { get; set; }
        public virtual DbSet<MusicShopTbl> MusicShopTbls { get; set; }
        public virtual DbSet<PeopleAndJobTbl> PeopleAndJobTbls { get; set; }
        public virtual DbSet<PerformanceCommentTbl> PerformanceCommentTbls { get; set; }
        public virtual DbSet<PerformanceLikeUnlikeTbl> PerformanceLikeUnlikeTbls { get; set; }
        public virtual DbSet<QuestionsTbl> QuestionsTbls { get; set; }
        public virtual DbSet<RepairShopTbl> RepairShopTbls { get; set; }
        public virtual DbSet<UserTypeTbl> UserTypeTbls { get; set; }
        public virtual DbSet<VenueTbl> VenueTbls { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<CollegeTbl> CollegeTbls { get; set; }
        public virtual DbSet<LookUpTbl> LookUpTbls { get; set; }
        public virtual DbSet<MusicianEndorserTbl> MusicianEndorserTbls { get; set; }
        public virtual DbSet<MusicianTbl> MusicianTbls { get; set; }
        public virtual DbSet<PerformanceGroupTbl> PerformanceGroupTbls { get; set; }
        public virtual DbSet<PerformanceMusicianInstrumentTbl> PerformanceMusicianInstrumentTbls { get; set; }
        public virtual DbSet<PerformanceTbl> PerformanceTbls { get; set; }
        public virtual DbSet<UserUserType> UserUserTypes { get; set; }
        public virtual DbSet<UserTbl> UserTbls { get; set; }
    }
}
