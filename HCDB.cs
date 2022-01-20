using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using HealthCareSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace HealthCareSystem
{
    public class HCDB : DbContext
    {
        public DbSet<Ambulance> Ambulances { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        //public DbSet<Drug> Drugs { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<WorkInability> WorkInabilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=HealtCareDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Patient>(x => x.HasKey(p => p.IdentificationNumber));
            //modelBuilder.Entity<Drug>(x => x.HasKey(p => p.RegistrationNumber));
        }
    }
}
