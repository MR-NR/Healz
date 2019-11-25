using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Healz.Migrations
{
    public partial class doctorprofiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorProfile",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    ProfilePhoto = table.Column<string>(nullable: true),
                    facebooklink = table.Column<string>(nullable: true),
                    twitterlink = table.Column<string>(nullable: true),
                    linkedin = table.Column<string>(nullable: true),
                    googlepluslink = table.Column<string>(nullable: true),
                    rsslink = table.Column<string>(nullable: true),
                    youtubelink = table.Column<string>(nullable: true),
                    Specializations = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    startingDateExperience = table.Column<DateTime>(nullable: false),
                    EndingDateExperience = table.Column<DateTime>(nullable: false),
                    DegreeName = table.Column<string>(nullable: true),
                    InstituteName = table.Column<string>(nullable: true),
                    StartingDateStudy = table.Column<DateTime>(nullable: false),
                    EndingDateStudy = table.Column<DateTime>(nullable: false),
                    Languages = table.Column<string>(nullable: true),
                    AwardTitle = table.Column<string>(nullable: true),
                    AwardOccasion = table.Column<string>(nullable: true),
                    AwardDate = table.Column<DateTime>(nullable: false),
                    MembershipTitle = table.Column<string>(nullable: true),
                    MembershipLocation = table.Column<string>(nullable: true),
                    MembershipDate = table.Column<DateTime>(nullable: false),
                    RegistrationID = table.Column<string>(nullable: true),
                    RegistrationLocation = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    AcceptedInsurance = table.Column<string>(nullable: true),
                    VideoIntroduction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorProfile", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorProfile");
        }
    }
}
