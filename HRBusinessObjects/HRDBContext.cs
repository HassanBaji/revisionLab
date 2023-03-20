using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HRBusinessObjects
{
    public partial class HRDBContext : DbContext
    {
        public HRDBContext()
        {
        }

        public HRDBContext(DbContextOptions<HRDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Dependent> Dependents { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Region> Regions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HumanResources;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CountryName).IsUnicode(false);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK__countries__regio__276EDEB3");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__departmen__locat__286302EC");
            });

            modelBuilder.Entity<Dependent>(entity =>
            {
                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Relationship).IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Dependents)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__dependent__emplo__29572725");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__employees__depar__2A4B4B5E");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__employees__job_i__2B3F6F97");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__employees__manag__2C3393D0");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobTitle).IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PostalCode).IsUnicode(false);

                entity.Property(e => e.StateProvince).IsUnicode(false);

                entity.Property(e => e.StreetAddress).IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__locations__count__2D27B809");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
