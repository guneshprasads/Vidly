namespace Vidly_2nd_try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatingdatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
