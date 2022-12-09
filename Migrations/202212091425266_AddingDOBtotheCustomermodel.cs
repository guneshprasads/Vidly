namespace Vidly_2nd_try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDOBtotheCustomermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Dateofbirth", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Dateofbirth");
        }
    }
}
