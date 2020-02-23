# Mubashra-Arshad-402
Voice Recognition Attendance Managment System
----------------------------------week 10--------------------------------------
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

--------------------------------------week 11--------------------------------------------------

<div>
    @{
        if (@Model.extra != "" && @Model.extra != null)
        {
            ViewBag.data = @Model.extra;
            <center class="alert alert-info">@Model.extra<a class='close' data-dismiss='alert'>&times;</a></center>
        }
    }
    <div class="content container-fluid">
        <div class="row">
            <div class="col-sm-4 col-xs-3">
                <h4 class="page-title">Home Page</h4>
            </div>

<div class="account-page">
    @{
        if (@Model.userType != null)
        {
            ViewBag.data = @Model.userType;
            <center class="alert alert-info">@Model.userType<a class='close' data-dismiss='alert'>&times;</a></center>
        }
    }

    <div class="container">
        <h3 class="account-title">AMS Login</h3>
        <div class="account-box">
            <div class="account-wrapper">
                <div class="account-logo">
                    <a href="#"><img src="../../Content/assets/img/logo2.png" alt="Focus Technologies"></a>
                </div>
                @using (Html.BeginForm("InstructorLogin", "Instructor"))
                {
                    <div class="form-group form-focus">
                        @Html.LabelFor(m => m.username, new { @class = "control-label" })
                        @Html.TextBoxFor(m => m.username, new { @class = "form-control floating", required = "required" })

                    </div>
                    <div class="form-group form-focus">
                        @Html.LabelFor(m => m.password, new { @class = "control-label" })
                        @Html.PasswordFor(m => m.password, new { @class = "form-control floating", required = "required" })

                    </div>
                    @*@Html.HiddenFor(m => m.id)*@

                    <div class="form-group text-center">
                        <button class="btn btn-primary btn-block account-btn" type="submit">Login</button>
                    </div>

                    <div class="text-center">
                        @Html.ActionLink("Login As Admin", "Index", "Home")
                    </div>
                }
            </div>
        </div>
    </div>
</div>

