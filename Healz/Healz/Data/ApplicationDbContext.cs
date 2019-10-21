using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Healz.Heals_Data;
using Healz.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Healz.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Physicin_ClinicInfo>()
              .HasKey(pt => new { pt.PhysicianId, pt.ClinicInfoId });

            modelBuilder.Entity<Physicin_ClinicInfo>()
                .HasOne(pt => pt.Physician)
                .WithMany(p => p.Physicin_ClinicInfos)
                .HasForeignKey(pt => pt.PhysicianId);

            modelBuilder.Entity<Physicin_ClinicInfo>()
                .HasOne(pt => pt.ClinicInfo)
                .WithMany(t => t.Physicin_ClinicInfos)
                .HasForeignKey(pt => pt.ClinicInfoId);
        }



        public DbSet<Registeration> Registerations { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<PatientInfo> patientInfos { get; set; }
        public DbSet<Physician> Physicians { get; set; }

        public DbSet<ClinicInfo> ClinicInfos { get; set; }

        public DbSet<Timing> Timings { get; set; }

        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<PhysicianQualification> PhysicianQualifications { get; set; }


        public DbSet<Visit> Visits { get; set; }
        public DbSet<Signs> Signs { get; set; }
        public DbSet<SignsValues> SignsValues { get; set; }

        public DbSet<PtientsSigns> patientsSigns { get; set; }
        public DbSet<PatientFamilyHistory> patientFamilyHistories { get; set; }
        public DbSet<PastHistory> pastHistories { get; set; }
        public DbSet<PatientLaboratoryTest> patientLaboratoryTests { get; set; }
        public DbSet<Symptoms> Symptoms { get; set; }
        public DbSet<SymptomsMedicine> symptomsMedicines { get; set; }

        public DbSet<PatientSymptoms> patientSymptoms { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Bill> Bills { get; set; }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Parameter> Parameters { get; set; }

        public DbSet<ParameterValue> ParameterValues { get; set; }
        public DbSet<RepotDetails> RepotDetails { get; set; }
        public DbSet<Healz.Models.BlogPost> BlogPost { get; set; }


    }
}
