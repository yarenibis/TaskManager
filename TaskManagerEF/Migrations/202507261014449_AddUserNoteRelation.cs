namespace TaskManagerEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserNoteRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Notes", "UserId");
            AddForeignKey("dbo.Notes", "UserId", "dbo.Users", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "UserId", "dbo.Users");
            DropIndex("dbo.Notes", new[] { "UserId" });
            DropColumn("dbo.Notes", "UserId");
        }
    }
}
