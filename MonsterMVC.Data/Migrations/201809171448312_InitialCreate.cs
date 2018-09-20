namespace MonsterMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActiveMonsters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EncounterId = c.Int(nullable: false),
                        MonsterId = c.Int(nullable: false),
                        HealthPoints = c.Int(nullable: false),
                        IsAlive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Encounters", t => t.EncounterId, cascadeDelete: true)
                .ForeignKey("dbo.MonsterDataModels", t => t.MonsterId, cascadeDelete: true)
                .Index(t => t.EncounterId)
                .Index(t => t.MonsterId);
            
            CreateTable(
                "dbo.Encounters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MonsterDataModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ChallengeRating = c.Single(nullable: false),
                        UrlId = c.Int(nullable: false),
                        Exp = c.Int(nullable: false),
                        EncounterParam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EncounterParams", t => t.EncounterParam_Id)
                .Index(t => t.EncounterParam_Id);
            
            CreateTable(
                "dbo.EncounterParams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Encounter_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Encounters", t => t.Encounter_Id)
                .Index(t => t.Encounter_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonsterDataModels", "EncounterParam_Id", "dbo.EncounterParams");
            DropForeignKey("dbo.EncounterParams", "Encounter_Id", "dbo.Encounters");
            DropForeignKey("dbo.ActiveMonsters", "MonsterId", "dbo.MonsterDataModels");
            DropForeignKey("dbo.ActiveMonsters", "EncounterId", "dbo.Encounters");
            DropIndex("dbo.EncounterParams", new[] { "Encounter_Id" });
            DropIndex("dbo.MonsterDataModels", new[] { "EncounterParam_Id" });
            DropIndex("dbo.ActiveMonsters", new[] { "MonsterId" });
            DropIndex("dbo.ActiveMonsters", new[] { "EncounterId" });
            DropTable("dbo.EncounterParams");
            DropTable("dbo.MonsterDataModels");
            DropTable("dbo.Encounters");
            DropTable("dbo.ActiveMonsters");
        }
    }
}
