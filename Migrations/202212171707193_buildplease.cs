namespace Vidly_2nd_try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buildplease : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Customers");
        }
        
        public override void Down()
        {
        }
    }
}
