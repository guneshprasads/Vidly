namespace Vidly_2nd_try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deletingalltheelementfrommovietable : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Movies");
        }
        
        public override void Down()
        {
        }
    }
}
