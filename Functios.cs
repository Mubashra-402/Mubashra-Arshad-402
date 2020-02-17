namespace Attendance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        section = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}


namespace Attendance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttributesToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "rollno", c => c.String());
            AddColumn("dbo.Students", "img_path", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "img_path");
            DropColumn("dbo.Students", "rollno");
        }
    }
}


namespace Attendance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentAttributeToProxy : DbMigration
    {
        public override void Up()
        {
            //CreateIndex("dbo.Proxies", "StudentId");
            //AddForeignKey("dbo.Proxies", "StudentId", "dbo.Students", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proxies", "StudentId", "dbo.Students");
            DropIndex("dbo.Proxies", new[] { "StudentId" });
        }
    }
}
