namespace DbCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetooneoneconnection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MessageContents", "MessageDetailsId", "dbo.MessageDetails");
            DropIndex("dbo.MessageContents", new[] { "MessageDetailsId" });
            AddColumn("dbo.MessageDetails", "MessageContent_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.MessageDetails", "MessageContent_Id");
            AddForeignKey("dbo.MessageDetails", "MessageContent_Id", "dbo.MessageContents", "Id", cascadeDelete: true);
            DropColumn("dbo.MessageContents", "MessageDetailsId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MessageContents", "MessageDetailsId", c => c.Long(nullable: false));
            DropForeignKey("dbo.MessageDetails", "MessageContent_Id", "dbo.MessageContents");
            DropIndex("dbo.MessageDetails", new[] { "MessageContent_Id" });
            DropColumn("dbo.MessageDetails", "MessageContent_Id");
            CreateIndex("dbo.MessageContents", "MessageDetailsId");
            AddForeignKey("dbo.MessageContents", "MessageDetailsId", "dbo.MessageDetails", "Id", cascadeDelete: true);
        }
    }
}
