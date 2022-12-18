namespace Vidly_2nd_try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeindataofbirthcustomers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Dateofbirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Dateofbirth", c => c.String());
        }
    }
}
