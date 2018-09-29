namespace DBContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Organizations", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Organizations", "Name", c => c.String(nullable: false));
        }
    }
}
