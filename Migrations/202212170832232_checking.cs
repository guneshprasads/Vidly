namespace Vidly_2nd_try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checking : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE From Movies");
        }
        
        public override void Down()
        {
        }
    }
}
