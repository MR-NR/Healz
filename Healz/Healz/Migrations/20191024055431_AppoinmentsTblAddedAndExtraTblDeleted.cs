using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Healz.Migrations
{
    public partial class AppoinmentsTblAddedAndExtraTblDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_patientInfos_PatientInfoId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Physicians_PhysicianId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "ParameterValues");

            migrationBuilder.DropTable(
                name: "pastHistories");

            migrationBuilder.DropTable(
                name: "patientFamilyHistories");

            migrationBuilder.DropTable(
                name: "patientLaboratoryTests");

            migrationBuilder.DropTable(
                name: "patientsSigns");

            migrationBuilder.DropTable(
                name: "patientSymptoms");

            migrationBuilder.DropTable(
                name: "PhysicianQualifications");

            migrationBuilder.DropTable(
                name: "Physicin_ClinicInfo");

            migrationBuilder.DropTable(
                name: "symptomsMedicines");

            migrationBuilder.DropTable(
                name: "Timings");

            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "patientInfos");

            migrationBuilder.DropTable(
                name: "RepotDetails");

            migrationBuilder.DropTable(
                name: "SignsValues");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "Physicians");

            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropTable(
                name: "ClinicInfos");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Signs");

            migrationBuilder.DropTable(
                name: "Registerations");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientInfoId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PhysicianId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PatientInfoId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PhysicianId",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "VisitStatus",
                table: "Appointments",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Appointments",
                newName: "AppointmentDate");

            migrationBuilder.AddColumn<bool>(
                name: "Action",
                table: "Appointments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Appointments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Appointments",
                newName: "VisitStatus");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "Appointments",
                newName: "Time");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Appointments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PatientInfoId",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhysicianId",
                table: "Appointments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClinicInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pastHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<DateTime>(nullable: false),
                    Dieses = table.Column<string>(nullable: true),
                    Duration = table.Column<DateTime>(nullable: false),
                    Medication = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pastHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registerations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    MembershipDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registerations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Signs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpecializationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppointmentId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Timings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClinicInfoId = table.Column<int>(nullable: true),
                    Day = table.Column<string>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timings_ClinicInfos_ClinicInfoId",
                        column: x => x.ClinicInfoId,
                        principalTable: "ClinicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "patientInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CNIC = table.Column<string>(nullable: true),
                    Cast = table.Column<string>(nullable: true),
                    Contact = table.Column<int>(nullable: false),
                    Designation = table.Column<string>(nullable: true),
                    MailingAddress = table.Column<string>(nullable: true),
                    MinitelStatus = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    PhysicalAddress = table.Column<string>(nullable: true),
                    RegisterationId = table.Column<int>(nullable: true),
                    ReligionName = table.Column<string>(nullable: true),
                    SpouseName = table.Column<string>(nullable: true),
                    SufferingFrom = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patientInfos_Registerations_RegisterationId",
                        column: x => x.RegisterationId,
                        principalTable: "Registerations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Physicians",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CNIC = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    MinitelStatus = table.Column<string>(nullable: true),
                    PostalAddress = table.Column<string>(nullable: true),
                    PracticingFrom = table.Column<string>(nullable: true),
                    ProfessionlStatement = table.Column<string>(nullable: true),
                    RegisterationId = table.Column<int>(nullable: true),
                    SpouseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physicians", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Physicians_Registerations_RegisterationId",
                        column: x => x.RegisterationId,
                        principalTable: "Registerations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignsValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SignsId = table.Column<int>(nullable: true),
                    Values = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignsValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignsValues_Signs_SignsId",
                        column: x => x.SignsId,
                        principalTable: "Signs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhysicianQualifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: true),
                    InstituteName = table.Column<string>(nullable: true),
                    ProcurementYear = table.Column<DateTime>(nullable: false),
                    QualificationName = table.Column<string>(nullable: true),
                    SpecializationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicianQualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicianQualifications_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "symptomsMedicines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(nullable: true),
                    Form = table.Column<string>(nullable: true),
                    Formula = table.Column<string>(nullable: true),
                    Garde = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SymptomsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_symptomsMedicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_symptomsMedicines_Symptoms_SymptomsId",
                        column: x => x.SymptomsId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaxValue = table.Column<string>(nullable: true),
                    MinValue = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NormalValue = table.Column<string>(nullable: true),
                    TestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parameters_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RepotDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrameterName = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    TestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepotDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepotDetails_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckPrice = table.Column<int>(nullable: false),
                    Detail = table.Column<string>(nullable: true),
                    MedicineTP = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<int>(nullable: false),
                    VisitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Durratin = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PerDay = table.Column<string>(nullable: true),
                    VisitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medications_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "patientSymptoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Duration = table.Column<DateTime>(nullable: false),
                    Intensity = table.Column<string>(nullable: true),
                    SymptomsId = table.Column<int>(nullable: true),
                    VisitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientSymptoms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patientSymptoms_Symptoms_SymptomsId",
                        column: x => x.SymptomsId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_patientSymptoms_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "patientFamilyHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alive_Dead = table.Column<string>(nullable: true),
                    CauseOfDeath = table.Column<string>(nullable: true),
                    DeathWithDate = table.Column<DateTime>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    PatientInfoId = table.Column<int>(nullable: true),
                    Relation = table.Column<string>(nullable: true),
                    SufferingFrom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientFamilyHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patientFamilyHistories_patientInfos_PatientInfoId",
                        column: x => x.PatientInfoId,
                        principalTable: "patientInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Physicin_ClinicInfo",
                columns: table => new
                {
                    PhysicianId = table.Column<int>(nullable: false),
                    ClinicInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physicin_ClinicInfo", x => new { x.PhysicianId, x.ClinicInfoId });
                    table.ForeignKey(
                        name: "FK_Physicin_ClinicInfo_ClinicInfos_ClinicInfoId",
                        column: x => x.ClinicInfoId,
                        principalTable: "ClinicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Physicin_ClinicInfo_Physicians_PhysicianId",
                        column: x => x.PhysicianId,
                        principalTable: "Physicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patientsSigns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SignsId = table.Column<int>(nullable: true),
                    SignsValuesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientsSigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patientsSigns_Signs_SignsId",
                        column: x => x.SignsId,
                        principalTable: "Signs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_patientsSigns_SignsValues_SignsValuesId",
                        column: x => x.SignsValuesId,
                        principalTable: "SignsValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParameterValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParameterId = table.Column<int>(nullable: true),
                    Values = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParameterValues_Parameters_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "Parameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "patientLaboratoryTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DoctorRemarks = table.Column<string>(nullable: true),
                    Lab = table.Column<string>(nullable: true),
                    RepotDetailsId = table.Column<int>(nullable: true),
                    TimeDate = table.Column<DateTime>(nullable: false),
                    VisitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientLaboratoryTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patientLaboratoryTests_RepotDetails_RepotDetailsId",
                        column: x => x.RepotDetailsId,
                        principalTable: "RepotDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_patientLaboratoryTests_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientInfoId",
                table: "Appointments",
                column: "PatientInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PhysicianId",
                table: "Appointments",
                column: "PhysicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_VisitId",
                table: "Bills",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Medications_VisitId",
                table: "Medications",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Parameters_TestId",
                table: "Parameters",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterValues_ParameterId",
                table: "ParameterValues",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_patientFamilyHistories_PatientInfoId",
                table: "patientFamilyHistories",
                column: "PatientInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_patientInfos_RegisterationId",
                table: "patientInfos",
                column: "RegisterationId");

            migrationBuilder.CreateIndex(
                name: "IX_patientLaboratoryTests_RepotDetailsId",
                table: "patientLaboratoryTests",
                column: "RepotDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_patientLaboratoryTests_VisitId",
                table: "patientLaboratoryTests",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_patientsSigns_SignsId",
                table: "patientsSigns",
                column: "SignsId");

            migrationBuilder.CreateIndex(
                name: "IX_patientsSigns_SignsValuesId",
                table: "patientsSigns",
                column: "SignsValuesId");

            migrationBuilder.CreateIndex(
                name: "IX_patientSymptoms_SymptomsId",
                table: "patientSymptoms",
                column: "SymptomsId");

            migrationBuilder.CreateIndex(
                name: "IX_patientSymptoms_VisitId",
                table: "patientSymptoms",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicianQualifications_SpecializationId",
                table: "PhysicianQualifications",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Physicians_RegisterationId",
                table: "Physicians",
                column: "RegisterationId");

            migrationBuilder.CreateIndex(
                name: "IX_Physicin_ClinicInfo_ClinicInfoId",
                table: "Physicin_ClinicInfo",
                column: "ClinicInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_RepotDetails_TestId",
                table: "RepotDetails",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_SignsValues_SignsId",
                table: "SignsValues",
                column: "SignsId");

            migrationBuilder.CreateIndex(
                name: "IX_symptomsMedicines_SymptomsId",
                table: "symptomsMedicines",
                column: "SymptomsId");

            migrationBuilder.CreateIndex(
                name: "IX_Timings_ClinicInfoId",
                table: "Timings",
                column: "ClinicInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_AppointmentId",
                table: "Visits",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_patientInfos_PatientInfoId",
                table: "Appointments",
                column: "PatientInfoId",
                principalTable: "patientInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Physicians_PhysicianId",
                table: "Appointments",
                column: "PhysicianId",
                principalTable: "Physicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
