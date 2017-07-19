namespace DbCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_column_and_index_creation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MessageDetails", "MessageBusEndpoint", c => c.String(nullable: false));
            AlterColumn("dbo.MessageDetails", "Type", c => c.String(nullable: false, maxLength: 250, unicode: false));
            AlterColumn("dbo.MessageDetails", "SourceSystem", c => c.String(maxLength: 250, unicode: false));
            AlterColumn("dbo.MessageDetails", "Environment", c => c.String());
            CreateIndex("dbo.MessageDetails", "Type");
        }
        
        public override void Down()
        {
            DropIndex("dbo.MessageDetails", new[] { "Type" });
            AlterColumn("dbo.MessageDetails", "Environment", c => c.String(nullable: false));
            AlterColumn("dbo.MessageDetails", "SourceSystem", c => c.String());
            AlterColumn("dbo.MessageDetails", "Type", c => c.String(nullable: false));
            DropColumn("dbo.MessageDetails", "MessageBusEndpoint");
        }
    }
}
