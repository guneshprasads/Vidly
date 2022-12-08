namespace Vidly_2nd_try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedatabaseofmembershiptype : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'payasyougo' WHERE DurationInMonths=0");
            Sql("UPDATE MembershipTypes SET Name = '1Month' WHERE DurationInMonths=1");
            Sql("UPDATE MembershipTypes SET Name = 'Montly' WHERE DurationInMonths=3");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE DurationInMonths=12");
        }
        
        public override void Down()
        {
        }
    }
}
