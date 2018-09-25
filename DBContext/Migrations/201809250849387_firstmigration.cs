namespace DBContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        BatchNo = c.Int(nullable: false),
                        Description = c.String(),
                        StartDate = c.String(),
                        EndDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                        Duration = c.Int(nullable: false),
                        Credit = c.Double(nullable: false),
                        Outline = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        ExamType = c.String(),
                        Code = c.String(),
                        Topics = c.String(),
                        FullMarks = c.Int(nullable: false),
                        ExamDuration = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoginDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        PassWord = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(),
                        Address = c.String(),
                        ContactNo = c.String(),
                        About = c.String(),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        BachId = c.Int(nullable: false),
                        Name = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                        Country = c.String(),
                        Profession = c.String(),
                        HighestAcademic = c.String(),
                        ProfilePicture = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        BachId = c.Int(nullable: false),
                        Name = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                        Country = c.String(),
                        ProfilePicture = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainers");
            DropTable("dbo.Participants");
            DropTable("dbo.Organizations");
            DropTable("dbo.LoginDatas");
            DropTable("dbo.Exams");
            DropTable("dbo.Courses");
            DropTable("dbo.Batches");
        }
    }
}
