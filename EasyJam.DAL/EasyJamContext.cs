using EasyJam.DAL.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EasyJam.DAL
{
    public class EasyJamContext : DbContext
    {
        public EasyJamContext()
    : base("EasyJamDatabase")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EasyJamContext>());
        }
        public DbSet<BattleEntity> BattleEntity { get; set; }
        public DbSet<BattleParticipantEntity> BattleParticipantEntity { get; set; }
        public DbSet<BattlePreliminaryEntity> BattlePreliminaryEntity { get; set; }
        public DbSet<BattleRecordEntity> BattleRecordEntity { get; set; }
        public DbSet<BattleRoundEntity> BattleRoundEntity { get; set; }
        public DbSet<CityEntity> CityEntity { get; set; }
        public DbSet<CountryEntity> CountryEntity { get; set; }
        public DbSet<CrewEntity> CrewEntity { get; set; }
        public DbSet<DancerEntity> DancerEntitiy { get; set; }
        public DbSet<DjEntity> DjEntity { get; set; }
        public DbSet<HostEntity> HostEntity { get; set; }
        public DbSet<JamEntity> JamEntity { get; set; }
        public DbSet<JudgeEntity> JudgeEntity { get; set; }
        public DbSet<SpeakerEntity> SpeakerEntity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
