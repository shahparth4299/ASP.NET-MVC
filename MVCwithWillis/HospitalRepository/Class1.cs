using Microsoft.EntityFrameworkCore;
using PatientLibrary;
using System;

namespace HospitalRepository
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
    : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .ToTable("tblPatient");
            modelBuilder.Entity<PatientProblem>()
                .ToTable("tblPatientProblem");
            modelBuilder.Entity<Treatment>()
                .ToTable("tblTreatment");

        }
        public DbSet<Patient> patients { get; set; }
    }
}
