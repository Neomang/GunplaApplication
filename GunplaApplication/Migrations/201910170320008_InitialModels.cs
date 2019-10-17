namespace GunplaApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gundam",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ModelNum = c.String(),
                        Series = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Gunpla",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ModelNum = c.String(),
                        ModelGrade = c.Int(nullable: false),
                        Scale = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Gundam_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Gundam", t => t.Gundam_ID)
                .Index(t => t.Gundam_ID);
            
            CreateTable(
                "dbo.Pilot",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Timeline = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PilotGundam",
                c => new
                    {
                        Pilot_ID = c.Int(nullable: false),
                        Gundam_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pilot_ID, t.Gundam_ID })
                .ForeignKey("dbo.Pilot", t => t.Pilot_ID, cascadeDelete: true)
                .ForeignKey("dbo.Gundam", t => t.Gundam_ID, cascadeDelete: true)
                .Index(t => t.Pilot_ID)
                .Index(t => t.Gundam_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PilotGundam", "Gundam_ID", "dbo.Gundam");
            DropForeignKey("dbo.PilotGundam", "Pilot_ID", "dbo.Pilot");
            DropForeignKey("dbo.Gunpla", "Gundam_ID", "dbo.Gundam");
            DropIndex("dbo.PilotGundam", new[] { "Gundam_ID" });
            DropIndex("dbo.PilotGundam", new[] { "Pilot_ID" });
            DropIndex("dbo.Gunpla", new[] { "Gundam_ID" });
            DropTable("dbo.PilotGundam");
            DropTable("dbo.Pilot");
            DropTable("dbo.Gunpla");
            DropTable("dbo.Gundam");
        }
    }
}
