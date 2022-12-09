namespace Vidly_2nd_try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateingtheDOB : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customer SET Dateofbirth = '25/04/1998' WHERE Id=1");
            Sql("UPDATE Customer SET Dateofbirth = '26/04/1998' WHERE Id=2");
            Sql("UPDATE Customer SET Dateofbirth = '26/05/1999' WHERE Id=3");
        }
        
        public override void Down()
        {
        }
    }
}
