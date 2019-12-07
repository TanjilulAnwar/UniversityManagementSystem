namespace UCMRS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dptf : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Semester_Id", "dbo.Semesters");
            DropIndex("dbo.Courses", new[] { "Semester_Id" });
            DropColumn("dbo.Courses", "Semester_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Semester_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Semester_Id");
            AddForeignKey("dbo.Courses", "Semester_Id", "dbo.Semesters", "Id");
        }
    }
}
