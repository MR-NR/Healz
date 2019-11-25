﻿// <auto-generated />
using System;
using Healz.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Healz.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191023073800_doctorprofiles1")]
    partial class doctorprofiles1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Healz.Heals_Data.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int?>("PatientInfoId");

                    b.Property<int?>("PhysicianId");

                    b.Property<DateTime>("Time");

                    b.Property<string>("VisitStatus");

                    b.HasKey("Id");

                    b.HasIndex("PatientInfoId");

                    b.HasIndex("PhysicianId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Healz.Heals_Data.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CheckPrice");

                    b.Property<string>("Detail");

                    b.Property<string>("MedicineTP");

                    b.Property<string>("Method");

                    b.Property<int>("TotalPrice");

                    b.Property<int?>("VisitId");

                    b.HasKey("Id");

                    b.HasIndex("VisitId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Healz.Heals_Data.ClinicInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Contact");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ClinicInfos");
                });

            modelBuilder.Entity("Healz.Heals_Data.Medication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Durratin");

                    b.Property<string>("Name");

                    b.Property<string>("PerDay");

                    b.Property<int?>("VisitId");

                    b.HasKey("Id");

                    b.HasIndex("VisitId");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("Healz.Heals_Data.Parameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaxValue");

                    b.Property<string>("MinValue");

                    b.Property<string>("Name");

                    b.Property<string>("NormalValue");

                    b.Property<int?>("TestId");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("Healz.Heals_Data.ParameterValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ParameterId");

                    b.Property<string>("Values");

                    b.HasKey("Id");

                    b.HasIndex("ParameterId");

                    b.ToTable("ParameterValues");
                });

            modelBuilder.Entity("Healz.Heals_Data.PastHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Age");

                    b.Property<string>("Dieses");

                    b.Property<DateTime>("Duration");

                    b.Property<string>("Medication");

                    b.HasKey("Id");

                    b.ToTable("pastHistories");
                });

            modelBuilder.Entity("Healz.Heals_Data.PatientFamilyHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alive_Dead");

                    b.Property<string>("CauseOfDeath");

                    b.Property<DateTime>("DeathWithDate");

                    b.Property<int>("Number");

                    b.Property<int?>("PatientInfoId");

                    b.Property<string>("Relation");

                    b.Property<string>("SufferingFrom");

                    b.HasKey("Id");

                    b.HasIndex("PatientInfoId");

                    b.ToTable("patientFamilyHistories");
                });

            modelBuilder.Entity("Healz.Heals_Data.PatientInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNIC");

                    b.Property<string>("Cast");

                    b.Property<int>("Contact");

                    b.Property<string>("Designation");

                    b.Property<string>("MailingAddress");

                    b.Property<string>("MinitelStatus");

                    b.Property<string>("MotherName");

                    b.Property<string>("Occupation");

                    b.Property<string>("PhysicalAddress");

                    b.Property<int?>("RegisterationId");

                    b.Property<string>("ReligionName");

                    b.Property<string>("SpouseName");

                    b.Property<string>("SufferingFrom");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("RegisterationId");

                    b.ToTable("patientInfos");
                });

            modelBuilder.Entity("Healz.Heals_Data.PatientLaboratoryTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DoctorRemarks");

                    b.Property<string>("Lab");

                    b.Property<int?>("RepotDetailsId");

                    b.Property<DateTime>("TimeDate");

                    b.Property<int?>("VisitId");

                    b.HasKey("Id");

                    b.HasIndex("RepotDetailsId");

                    b.HasIndex("VisitId");

                    b.ToTable("patientLaboratoryTests");
                });

            modelBuilder.Entity("Healz.Heals_Data.PatientSymptoms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Duration");

                    b.Property<string>("Intensity");

                    b.Property<int?>("SymptomsId");

                    b.Property<int?>("VisitId");

                    b.HasKey("Id");

                    b.HasIndex("SymptomsId");

                    b.HasIndex("VisitId");

                    b.ToTable("patientSymptoms");
                });

            modelBuilder.Entity("Healz.Heals_Data.Physician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNIC");

                    b.Property<string>("Contact");

                    b.Property<string>("MinitelStatus");

                    b.Property<string>("PostalAddress");

                    b.Property<string>("PracticingFrom");

                    b.Property<string>("ProfessionlStatement");

                    b.Property<int?>("RegisterationId");

                    b.Property<string>("SpouseName");

                    b.HasKey("Id");

                    b.HasIndex("RegisterationId");

                    b.ToTable("Physicians");
                });

            modelBuilder.Entity("Healz.Heals_Data.PhysicianQualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<string>("InstituteName");

                    b.Property<DateTime>("ProcurementYear");

                    b.Property<string>("QualificationName");

                    b.Property<int?>("SpecializationId");

                    b.HasKey("Id");

                    b.HasIndex("SpecializationId");

                    b.ToTable("PhysicianQualifications");
                });

            modelBuilder.Entity("Healz.Heals_Data.Physicin_ClinicInfo", b =>
                {
                    b.Property<int>("PhysicianId");

                    b.Property<int>("ClinicInfoId");

                    b.HasKey("PhysicianId", "ClinicInfoId");

                    b.HasIndex("ClinicInfoId");

                    b.ToTable("Physicin_ClinicInfo");
                });

            modelBuilder.Entity("Healz.Heals_Data.PtientsSigns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SignsId");

                    b.Property<int?>("SignsValuesId");

                    b.HasKey("Id");

                    b.HasIndex("SignsId");

                    b.HasIndex("SignsValuesId");

                    b.ToTable("patientsSigns");
                });

            modelBuilder.Entity("Healz.Heals_Data.Registeration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Gender");

                    b.Property<DateTime>("MembershipDate");

                    b.HasKey("Id");

                    b.ToTable("Registerations");
                });

            modelBuilder.Entity("Healz.Heals_Data.RepotDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrameterName");

                    b.Property<string>("Result");

                    b.Property<int?>("TestId");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("RepotDetails");
                });

            modelBuilder.Entity("Healz.Heals_Data.Signs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Signs");
                });

            modelBuilder.Entity("Healz.Heals_Data.SignsValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SignsId");

                    b.Property<int>("Values");

                    b.HasKey("Id");

                    b.HasIndex("SignsId");

                    b.ToTable("SignsValues");
                });

            modelBuilder.Entity("Healz.Heals_Data.Specialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SpecializationName");

                    b.HasKey("Id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("Healz.Heals_Data.Symptoms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("Healz.Heals_Data.SymptomsMedicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company");

                    b.Property<string>("Form");

                    b.Property<string>("Formula");

                    b.Property<string>("Garde");

                    b.Property<string>("Name");

                    b.Property<int?>("SymptomsId");

                    b.HasKey("Id");

                    b.HasIndex("SymptomsId");

                    b.ToTable("symptomsMedicines");
                });

            modelBuilder.Entity("Healz.Heals_Data.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Healz.Heals_Data.Timing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClinicInfoId");

                    b.Property<string>("Day");

                    b.Property<DateTime>("EndTime");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ClinicInfoId");

                    b.ToTable("Timings");
                });

            modelBuilder.Entity("Healz.Heals_Data.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("Healz.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Title");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Healz.Models.BlogPost", b =>
                {
                    b.Property<int>("BlogPostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("postDate");

                    b.Property<string>("postDesc");

                    b.Property<string>("postImgUrl");

                    b.Property<string>("postTitle");

                    b.Property<string>("postedBy");

                    b.HasKey("BlogPostId");

                    b.ToTable("BlogPost");
                });

            modelBuilder.Entity("Healz.Models.DoctorProfile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcceptedInsurance");

                    b.Property<DateTime>("AwardDate");

                    b.Property<string>("AwardOccasion");

                    b.Property<string>("AwardTitle");

                    b.Property<string>("CompanyName");

                    b.Property<string>("DegreeName");

                    b.Property<string>("Designation");

                    b.Property<DateTime>("EndingDateExperience");

                    b.Property<DateTime>("EndingDateStudy");

                    b.Property<string>("FirstName");

                    b.Property<string>("InstituteName");

                    b.Property<string>("Languages");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("MembershipDate");

                    b.Property<string>("MembershipLocation");

                    b.Property<string>("MembershipTitle");

                    b.Property<string>("ProfilePhoto");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<string>("RegistrationID");

                    b.Property<string>("RegistrationLocation");

                    b.Property<string>("Specializations");

                    b.Property<DateTime>("StartingDateStudy");

                    b.Property<string>("SubTitle");

                    b.Property<string>("Title");

                    b.Property<string>("VideoIntroduction");

                    b.Property<string>("facebooklink");

                    b.Property<string>("googlepluslink");

                    b.Property<string>("linkedin");

                    b.Property<string>("rsslink");

                    b.Property<DateTime>("startingDateExperience");

                    b.Property<string>("twitterlink");

                    b.Property<string>("youtubelink");

                    b.HasKey("id");

                    b.ToTable("DoctorProfile");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Healz.Heals_Data.Appointment", b =>
                {
                    b.HasOne("Healz.Heals_Data.PatientInfo", "PatientInfo")
                        .WithMany()
                        .HasForeignKey("PatientInfoId");

                    b.HasOne("Healz.Heals_Data.Physician", "Physician")
                        .WithMany()
                        .HasForeignKey("PhysicianId");
                });

            modelBuilder.Entity("Healz.Heals_Data.Bill", b =>
                {
                    b.HasOne("Healz.Heals_Data.Visit", "Visit")
                        .WithMany()
                        .HasForeignKey("VisitId");
                });

            modelBuilder.Entity("Healz.Heals_Data.Medication", b =>
                {
                    b.HasOne("Healz.Heals_Data.Visit", "Visit")
                        .WithMany()
                        .HasForeignKey("VisitId");
                });

            modelBuilder.Entity("Healz.Heals_Data.Parameter", b =>
                {
                    b.HasOne("Healz.Heals_Data.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("Healz.Heals_Data.ParameterValue", b =>
                {
                    b.HasOne("Healz.Heals_Data.Parameter", "Parameter")
                        .WithMany()
                        .HasForeignKey("ParameterId");
                });

            modelBuilder.Entity("Healz.Heals_Data.PatientFamilyHistory", b =>
                {
                    b.HasOne("Healz.Heals_Data.PatientInfo", "PatientInfo")
                        .WithMany()
                        .HasForeignKey("PatientInfoId");
                });

            modelBuilder.Entity("Healz.Heals_Data.PatientInfo", b =>
                {
                    b.HasOne("Healz.Heals_Data.Registeration", "Registeration")
                        .WithMany()
                        .HasForeignKey("RegisterationId");
                });

            modelBuilder.Entity("Healz.Heals_Data.PatientLaboratoryTest", b =>
                {
                    b.HasOne("Healz.Heals_Data.RepotDetails", "RepotDetails")
                        .WithMany()
                        .HasForeignKey("RepotDetailsId");

                    b.HasOne("Healz.Heals_Data.Visit", "Visit")
                        .WithMany()
                        .HasForeignKey("VisitId");
                });

            modelBuilder.Entity("Healz.Heals_Data.PatientSymptoms", b =>
                {
                    b.HasOne("Healz.Heals_Data.Symptoms", "Symptoms")
                        .WithMany()
                        .HasForeignKey("SymptomsId");

                    b.HasOne("Healz.Heals_Data.Visit", "Visit")
                        .WithMany()
                        .HasForeignKey("VisitId");
                });

            modelBuilder.Entity("Healz.Heals_Data.Physician", b =>
                {
                    b.HasOne("Healz.Heals_Data.Registeration", "Registeration")
                        .WithMany()
                        .HasForeignKey("RegisterationId");
                });

            modelBuilder.Entity("Healz.Heals_Data.PhysicianQualification", b =>
                {
                    b.HasOne("Healz.Heals_Data.Specialization", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId");
                });

            modelBuilder.Entity("Healz.Heals_Data.Physicin_ClinicInfo", b =>
                {
                    b.HasOne("Healz.Heals_Data.ClinicInfo", "ClinicInfo")
                        .WithMany("Physicin_ClinicInfos")
                        .HasForeignKey("ClinicInfoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Healz.Heals_Data.Physician", "Physician")
                        .WithMany("Physicin_ClinicInfos")
                        .HasForeignKey("PhysicianId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Healz.Heals_Data.PtientsSigns", b =>
                {
                    b.HasOne("Healz.Heals_Data.Signs", "Signs")
                        .WithMany()
                        .HasForeignKey("SignsId");

                    b.HasOne("Healz.Heals_Data.SignsValues", "SignsValues")
                        .WithMany()
                        .HasForeignKey("SignsValuesId");
                });

            modelBuilder.Entity("Healz.Heals_Data.RepotDetails", b =>
                {
                    b.HasOne("Healz.Heals_Data.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("Healz.Heals_Data.SignsValues", b =>
                {
                    b.HasOne("Healz.Heals_Data.Signs", "Signs")
                        .WithMany()
                        .HasForeignKey("SignsId");
                });

            modelBuilder.Entity("Healz.Heals_Data.SymptomsMedicine", b =>
                {
                    b.HasOne("Healz.Heals_Data.Symptoms", "Symptoms")
                        .WithMany()
                        .HasForeignKey("SymptomsId");
                });

            modelBuilder.Entity("Healz.Heals_Data.Timing", b =>
                {
                    b.HasOne("Healz.Heals_Data.ClinicInfo", "ClinicInfo")
                        .WithMany()
                        .HasForeignKey("ClinicInfoId");
                });

            modelBuilder.Entity("Healz.Heals_Data.Visit", b =>
                {
                    b.HasOne("Healz.Heals_Data.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Healz.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Healz.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Healz.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Healz.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
