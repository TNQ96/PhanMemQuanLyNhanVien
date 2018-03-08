namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeManagementDBContext : DbContext
    {
        public EmployeeManagementDBContext()
            : base("name=EmployeeManagementDBContext")
        {
        }

        public virtual DbSet<PdbAccount> PdbAccounts { get; set; }
        public virtual DbSet<PdbBonusSalary> PdbBonusSalaries { get; set; }
        public virtual DbSet<PdbContract> PdbContracts { get; set; }
        public virtual DbSet<PdbEducationLevel> PdbEducationLevels { get; set; }
        public virtual DbSet<PdbEvent> PdbEvents { get; set; }
        public virtual DbSet<PdbFeedBack> PdbFeedBacks { get; set; }
        public virtual DbSet<PdbStaff> PdbStaffs { get; set; }
        public virtual DbSet<PdbStaffEvent> PdbStaffEvents { get; set; }
        public virtual DbSet<PdbSupply> PdbSupplies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PdbAccount>()
                .Property(e => e.AccountName)
                .IsFixedLength();

            modelBuilder.Entity<PdbAccount>()
                .Property(e => e.AccountPassword)
                .IsFixedLength();

            modelBuilder.Entity<PdbBonusSalary>()
                .Property(e => e.MoneyBonus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbBonusSalary>()
                .Property(e => e.MonthBonus)
                .IsFixedLength();

            modelBuilder.Entity<PdbBonusSalary>()
                .Property(e => e.YearBonus)
                .IsFixedLength();

            modelBuilder.Entity<PdbEvent>()
                .Property(e => e.ExpectedCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbEvent>()
                .Property(e => e.CostsAwarded)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbEvent>()
                .Property(e => e.ActualCosts)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbEvent>()
                .Property(e => e.Money_Staff_Pay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbEvent>()
                .HasMany(e => e.PdbStaffEvents)
                .WithRequired(e => e.PdbEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PdbFeedBack>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<PdbStaff>()
                .Property(e => e.IndentityCard)
                .IsFixedLength();

            modelBuilder.Entity<PdbStaff>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<PdbStaff>()
                .Property(e => e.AddressNumber)
                .IsFixedLength();

            modelBuilder.Entity<PdbStaff>()
                .Property(e => e.AddressWard)
                .IsFixedLength();

            modelBuilder.Entity<PdbStaff>()
                .Property(e => e.SalaryBasic)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PdbStaff>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<PdbStaff>()
                .HasMany(e => e.PdbAccounts)
                .WithRequired(e => e.PdbStaff)
                .HasForeignKey(e => e.IDStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PdbStaff>()
                .HasMany(e => e.PdbBonusSalaries)
                .WithRequired(e => e.PdbStaff)
                .HasForeignKey(e => e.IDStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PdbStaff>()
                .HasMany(e => e.PdbContracts)
                .WithRequired(e => e.PdbStaff)
                .HasForeignKey(e => e.IDStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PdbStaff>()
                .HasMany(e => e.PdbEducationLevels)
                .WithRequired(e => e.PdbStaff)
                .HasForeignKey(e => e.IDStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PdbStaff>()
                .HasMany(e => e.PdbStaffEvents)
                .WithRequired(e => e.PdbStaff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PdbStaff>()
                .HasMany(e => e.PdbSupplies)
                .WithRequired(e => e.PdbStaff)
                .HasForeignKey(e => e.IDStaff)
                .WillCascadeOnDelete(false);
        }
    }
}
