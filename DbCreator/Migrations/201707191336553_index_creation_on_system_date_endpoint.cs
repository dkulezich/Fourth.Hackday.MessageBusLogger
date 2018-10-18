namespace DbCreator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class index_creation_on_system_date_endpoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MessageDetails", "MessageBusEndpoint", c => c.String(nullable: false, maxLength: 400));
            CreateIndex("dbo.MessageDetails", "SourceSystem");
            CreateIndex("dbo.MessageDetails", "Date");
        }
        
        public override void Down()
        {
            DropIndex("dbo.MessageDetails", new[] { "Date" });
            DropIndex("dbo.MessageDetails", new[] { "SourceSystem" });
            AlterColumn("dbo.MessageDetails", "MessageBusEndpoint", c => c.String(nullable: false));
        }
    }
}
