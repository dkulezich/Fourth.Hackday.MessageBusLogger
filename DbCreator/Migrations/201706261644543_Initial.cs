namespace DbCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MessageContents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Message = c.String(nullable: false),
                        MessageDetailsId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MessageDetails", t => t.MessageDetailsId, cascadeDelete: true)
                .Index(t => t.MessageDetailsId);
            
            CreateTable(
                "dbo.MessageDetails",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                        SourceSystem = c.String(),
                        TrackingId = c.String(),
                        Date = c.DateTime(nullable: false),
                        Environment = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MessageContents", "MessageDetailsId", "dbo.MessageDetails");
            DropIndex("dbo.MessageContents", new[] { "MessageDetailsId" });
            DropTable("dbo.MessageDetails");
            DropTable("dbo.MessageContents");
        }
    }
}
