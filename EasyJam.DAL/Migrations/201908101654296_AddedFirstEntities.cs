namespace EasyJam.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFirstEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BattleEntity",
                c => new
                    {
                        BattleId = c.Int(nullable: false, identity: true),
                        BattleName = c.String(nullable: false, maxLength: 50),
                        Type = c.Int(nullable: false),
                        ScheduledTime = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Location = c.String(nullable: false),
                        BattlePreliminary_BattlePreliminaryId = c.Int(),
                        JamEntity_JamId = c.Int(),
                    })
                .PrimaryKey(t => t.BattleId)
                .ForeignKey("dbo.BattlePreliminaryEntity", t => t.BattlePreliminary_BattlePreliminaryId)
                .ForeignKey("dbo.JamEntity", t => t.JamEntity_JamId)
                .Index(t => t.BattlePreliminary_BattlePreliminaryId)
                .Index(t => t.JamEntity_JamId);
            
            CreateTable(
                "dbo.BattlePreliminaryEntity",
                c => new
                    {
                        BattlePreliminaryId = c.Int(nullable: false, identity: true),
                        ScheduledTime = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BattlePreliminaryId);
            
            CreateTable(
                "dbo.BattleParticipantEntity",
                c => new
                    {
                        BattleEntryId = c.Int(nullable: false, identity: true),
                        BattleBlaze = c.String(nullable: false, maxLength: 50),
                        SubscritpionDate = c.DateTime(nullable: false),
                        Rank = c.Int(),
                    })
                .PrimaryKey(t => t.BattleEntryId);
            
            CreateTable(
                "dbo.BattleRecordEntity",
                c => new
                    {
                        BattleRecordId = c.Int(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        ScheduledTime = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Battle_BattleId = c.Int(),
                        Loser_BattleEntryId = c.Int(),
                        Winner_BattleEntryId = c.Int(),
                    })
                .PrimaryKey(t => t.BattleRecordId)
                .ForeignKey("dbo.BattleEntity", t => t.Battle_BattleId)
                .ForeignKey("dbo.BattleParticipantEntity", t => t.Loser_BattleEntryId)
                .ForeignKey("dbo.BattleParticipantEntity", t => t.Winner_BattleEntryId)
                .Index(t => t.Battle_BattleId)
                .Index(t => t.Loser_BattleEntryId)
                .Index(t => t.Winner_BattleEntryId);
            
            CreateTable(
                "dbo.BattleRoundEntity",
                c => new
                    {
                        BattleRoundId = c.Int(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        ScheduledTime = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Loser_BattleEntryId = c.Int(),
                        Winner_BattleEntryId = c.Int(),
                    })
                .PrimaryKey(t => t.BattleRoundId)
                .ForeignKey("dbo.BattleParticipantEntity", t => t.Loser_BattleEntryId)
                .ForeignKey("dbo.BattleParticipantEntity", t => t.Winner_BattleEntryId)
                .Index(t => t.Loser_BattleEntryId)
                .Index(t => t.Winner_BattleEntryId);
            
            CreateTable(
                "dbo.CityEntity",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false, maxLength: 50),
                        CrewEntity_CrewId = c.Int(),
                        DancerEntity_DancerId = c.Int(),
                        DjEntity_DjId = c.Int(),
                        HostEntity_HostId = c.Int(),
                        JudgeEntity_JudgeId = c.Int(),
                        SpeakerEntity_SpeakerId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.CrewEntity", t => t.CrewEntity_CrewId)
                .ForeignKey("dbo.DancerEntity", t => t.DancerEntity_DancerId)
                .ForeignKey("dbo.DjEntity", t => t.DjEntity_DjId)
                .ForeignKey("dbo.HostEntity", t => t.HostEntity_HostId)
                .ForeignKey("dbo.JudgeEntity", t => t.JudgeEntity_JudgeId)
                .ForeignKey("dbo.SpeakerEntity", t => t.SpeakerEntity_SpeakerId)
                .Index(t => t.CrewEntity_CrewId)
                .Index(t => t.DancerEntity_DancerId)
                .Index(t => t.DjEntity_DjId)
                .Index(t => t.HostEntity_HostId)
                .Index(t => t.JudgeEntity_JudgeId)
                .Index(t => t.SpeakerEntity_SpeakerId);
            
            CreateTable(
                "dbo.CountryEntity",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 50),
                        CrewEntity_CrewId = c.Int(),
                        DancerEntity_DancerId = c.Int(),
                        DjEntity_DjId = c.Int(),
                        HostEntity_HostId = c.Int(),
                        JudgeEntity_JudgeId = c.Int(),
                        SpeakerEntity_SpeakerId = c.Int(),
                    })
                .PrimaryKey(t => t.CountryId)
                .ForeignKey("dbo.CrewEntity", t => t.CrewEntity_CrewId)
                .ForeignKey("dbo.DancerEntity", t => t.DancerEntity_DancerId)
                .ForeignKey("dbo.DjEntity", t => t.DjEntity_DjId)
                .ForeignKey("dbo.HostEntity", t => t.HostEntity_HostId)
                .ForeignKey("dbo.JudgeEntity", t => t.JudgeEntity_JudgeId)
                .ForeignKey("dbo.SpeakerEntity", t => t.SpeakerEntity_SpeakerId)
                .Index(t => t.CrewEntity_CrewId)
                .Index(t => t.DancerEntity_DancerId)
                .Index(t => t.DjEntity_DjId)
                .Index(t => t.HostEntity_HostId)
                .Index(t => t.JudgeEntity_JudgeId)
                .Index(t => t.SpeakerEntity_SpeakerId);
            
            CreateTable(
                "dbo.CrewEntity",
                c => new
                    {
                        CrewId = c.Int(nullable: false, identity: true),
                        CrewName = c.String(),
                        DancerEntity_DancerId = c.Int(),
                        DjEntity_DjId = c.Int(),
                        HostEntity_HostId = c.Int(),
                        JudgeEntity_JudgeId = c.Int(),
                        SpeakerEntity_SpeakerId = c.Int(),
                    })
                .PrimaryKey(t => t.CrewId)
                .ForeignKey("dbo.DancerEntity", t => t.DancerEntity_DancerId)
                .ForeignKey("dbo.DjEntity", t => t.DjEntity_DjId)
                .ForeignKey("dbo.HostEntity", t => t.HostEntity_HostId)
                .ForeignKey("dbo.JudgeEntity", t => t.JudgeEntity_JudgeId)
                .ForeignKey("dbo.SpeakerEntity", t => t.SpeakerEntity_SpeakerId)
                .Index(t => t.DancerEntity_DancerId)
                .Index(t => t.DjEntity_DjId)
                .Index(t => t.HostEntity_HostId)
                .Index(t => t.JudgeEntity_JudgeId)
                .Index(t => t.SpeakerEntity_SpeakerId);
            
            CreateTable(
                "dbo.DancerEntity",
                c => new
                    {
                        DancerId = c.Int(nullable: false, identity: true),
                        Blaze = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 1),
                        Email = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        SignInDate = c.DateTime(nullable: false),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.DancerId);
            
            CreateTable(
                "dbo.DjEntity",
                c => new
                    {
                        DjId = c.Int(nullable: false, identity: true),
                        Blaze = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 1),
                        Email = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        SignInDate = c.DateTime(nullable: false),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.DjId);
            
            CreateTable(
                "dbo.HostEntity",
                c => new
                    {
                        HostId = c.Int(nullable: false, identity: true),
                        Blaze = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 1),
                        Email = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        SignInDate = c.DateTime(nullable: false),
                        Age = c.String(),
                        JamEntity_JamId = c.Int(),
                    })
                .PrimaryKey(t => t.HostId)
                .ForeignKey("dbo.JamEntity", t => t.JamEntity_JamId)
                .Index(t => t.JamEntity_JamId);
            
            CreateTable(
                "dbo.JamEntity",
                c => new
                    {
                        JamId = c.Int(nullable: false, identity: true),
                        JamName = c.String(),
                        ScheduledTime = c.DateTime(nullable: false),
                        startTime = c.DateTime(nullable: false),
                        Location = c.String(nullable: false),
                        City_CityId = c.Int(),
                        Country_CountryId = c.Int(),
                    })
                .PrimaryKey(t => t.JamId)
                .ForeignKey("dbo.CityEntity", t => t.City_CityId)
                .ForeignKey("dbo.CountryEntity", t => t.Country_CountryId)
                .Index(t => t.City_CityId)
                .Index(t => t.Country_CountryId);
            
            CreateTable(
                "dbo.JudgeEntity",
                c => new
                    {
                        JudgeId = c.Int(nullable: false, identity: true),
                        Blaze = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 1),
                        Email = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        SignInDate = c.DateTime(nullable: false),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.JudgeId);
            
            CreateTable(
                "dbo.SpeakerEntity",
                c => new
                    {
                        SpeakerId = c.Int(nullable: false, identity: true),
                        Blaze = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 1),
                        Email = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        SignInDate = c.DateTime(nullable: false),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.SpeakerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CrewEntity", "SpeakerEntity_SpeakerId", "dbo.SpeakerEntity");
            DropForeignKey("dbo.CountryEntity", "SpeakerEntity_SpeakerId", "dbo.SpeakerEntity");
            DropForeignKey("dbo.CityEntity", "SpeakerEntity_SpeakerId", "dbo.SpeakerEntity");
            DropForeignKey("dbo.CrewEntity", "JudgeEntity_JudgeId", "dbo.JudgeEntity");
            DropForeignKey("dbo.CountryEntity", "JudgeEntity_JudgeId", "dbo.JudgeEntity");
            DropForeignKey("dbo.CityEntity", "JudgeEntity_JudgeId", "dbo.JudgeEntity");
            DropForeignKey("dbo.HostEntity", "JamEntity_JamId", "dbo.JamEntity");
            DropForeignKey("dbo.JamEntity", "Country_CountryId", "dbo.CountryEntity");
            DropForeignKey("dbo.JamEntity", "City_CityId", "dbo.CityEntity");
            DropForeignKey("dbo.BattleEntity", "JamEntity_JamId", "dbo.JamEntity");
            DropForeignKey("dbo.CrewEntity", "HostEntity_HostId", "dbo.HostEntity");
            DropForeignKey("dbo.CountryEntity", "HostEntity_HostId", "dbo.HostEntity");
            DropForeignKey("dbo.CityEntity", "HostEntity_HostId", "dbo.HostEntity");
            DropForeignKey("dbo.CrewEntity", "DjEntity_DjId", "dbo.DjEntity");
            DropForeignKey("dbo.CountryEntity", "DjEntity_DjId", "dbo.DjEntity");
            DropForeignKey("dbo.CityEntity", "DjEntity_DjId", "dbo.DjEntity");
            DropForeignKey("dbo.CrewEntity", "DancerEntity_DancerId", "dbo.DancerEntity");
            DropForeignKey("dbo.CountryEntity", "DancerEntity_DancerId", "dbo.DancerEntity");
            DropForeignKey("dbo.CityEntity", "DancerEntity_DancerId", "dbo.DancerEntity");
            DropForeignKey("dbo.CountryEntity", "CrewEntity_CrewId", "dbo.CrewEntity");
            DropForeignKey("dbo.CityEntity", "CrewEntity_CrewId", "dbo.CrewEntity");
            DropForeignKey("dbo.BattleRoundEntity", "Winner_BattleEntryId", "dbo.BattleParticipantEntity");
            DropForeignKey("dbo.BattleRoundEntity", "Loser_BattleEntryId", "dbo.BattleParticipantEntity");
            DropForeignKey("dbo.BattleRecordEntity", "Winner_BattleEntryId", "dbo.BattleParticipantEntity");
            DropForeignKey("dbo.BattleRecordEntity", "Loser_BattleEntryId", "dbo.BattleParticipantEntity");
            DropForeignKey("dbo.BattleRecordEntity", "Battle_BattleId", "dbo.BattleEntity");
            DropForeignKey("dbo.BattleEntity", "BattlePreliminary_BattlePreliminaryId", "dbo.BattlePreliminaryEntity");
            DropIndex("dbo.JamEntity", new[] { "Country_CountryId" });
            DropIndex("dbo.JamEntity", new[] { "City_CityId" });
            DropIndex("dbo.HostEntity", new[] { "JamEntity_JamId" });
            DropIndex("dbo.CrewEntity", new[] { "SpeakerEntity_SpeakerId" });
            DropIndex("dbo.CrewEntity", new[] { "JudgeEntity_JudgeId" });
            DropIndex("dbo.CrewEntity", new[] { "HostEntity_HostId" });
            DropIndex("dbo.CrewEntity", new[] { "DjEntity_DjId" });
            DropIndex("dbo.CrewEntity", new[] { "DancerEntity_DancerId" });
            DropIndex("dbo.CountryEntity", new[] { "SpeakerEntity_SpeakerId" });
            DropIndex("dbo.CountryEntity", new[] { "JudgeEntity_JudgeId" });
            DropIndex("dbo.CountryEntity", new[] { "HostEntity_HostId" });
            DropIndex("dbo.CountryEntity", new[] { "DjEntity_DjId" });
            DropIndex("dbo.CountryEntity", new[] { "DancerEntity_DancerId" });
            DropIndex("dbo.CountryEntity", new[] { "CrewEntity_CrewId" });
            DropIndex("dbo.CityEntity", new[] { "SpeakerEntity_SpeakerId" });
            DropIndex("dbo.CityEntity", new[] { "JudgeEntity_JudgeId" });
            DropIndex("dbo.CityEntity", new[] { "HostEntity_HostId" });
            DropIndex("dbo.CityEntity", new[] { "DjEntity_DjId" });
            DropIndex("dbo.CityEntity", new[] { "DancerEntity_DancerId" });
            DropIndex("dbo.CityEntity", new[] { "CrewEntity_CrewId" });
            DropIndex("dbo.BattleRoundEntity", new[] { "Winner_BattleEntryId" });
            DropIndex("dbo.BattleRoundEntity", new[] { "Loser_BattleEntryId" });
            DropIndex("dbo.BattleRecordEntity", new[] { "Winner_BattleEntryId" });
            DropIndex("dbo.BattleRecordEntity", new[] { "Loser_BattleEntryId" });
            DropIndex("dbo.BattleRecordEntity", new[] { "Battle_BattleId" });
            DropIndex("dbo.BattleEntity", new[] { "JamEntity_JamId" });
            DropIndex("dbo.BattleEntity", new[] { "BattlePreliminary_BattlePreliminaryId" });
            DropTable("dbo.SpeakerEntity");
            DropTable("dbo.JudgeEntity");
            DropTable("dbo.JamEntity");
            DropTable("dbo.HostEntity");
            DropTable("dbo.DjEntity");
            DropTable("dbo.DancerEntity");
            DropTable("dbo.CrewEntity");
            DropTable("dbo.CountryEntity");
            DropTable("dbo.CityEntity");
            DropTable("dbo.BattleRoundEntity");
            DropTable("dbo.BattleRecordEntity");
            DropTable("dbo.BattleParticipantEntity");
            DropTable("dbo.BattlePreliminaryEntity");
            DropTable("dbo.BattleEntity");
        }
    }
}
