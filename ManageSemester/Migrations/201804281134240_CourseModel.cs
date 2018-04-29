namespace ManageSemester.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course", "Title", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Course", "Title", c => c.String());
        }
    }
}
