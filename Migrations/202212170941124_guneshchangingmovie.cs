namespace Vidly_2nd_try.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class guneshchangingmovie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropColumn("dbo.Movies", "GenerId");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenerId");
            AlterColumn("dbo.Movies", "GenerId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "GenerId");
            AddForeignKey("dbo.Movies", "GenerId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenerId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenerId" });
            AlterColumn("dbo.Movies", "GenerId", c => c.Byte());
            RenameColumn(table: "dbo.Movies", name: "GenerId", newName: "Genre_Id");
            AddColumn("dbo.Movies", "GenerId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
