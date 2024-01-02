using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public AppDbContext()
        {

        }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<DayOff> DayOffs { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }
        public DbSet<AverageSalaryByDepartment> AverageSalaryByDepartments { get; set; }
        public DbSet<TotalEmployees> TotalEmployees { get; set; }

        public DbSet<TotalDepartmanCount> TotalDepartmanCounts { get; set; }


        [DbFunction("dbo", "GetMonthlyPayrollForEmployee")]
        public static IQueryable<PaymentInfo> GetMonthlyPayrollForEmployee(int personelId, int istenilenAy, int istenilenYil)
        {
            throw new NotSupportedException("Direct calls are not supported.");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder
                .Entity<AverageSalaryByDepartment>(eb =>
                {
                    eb.HasNoKey(); 
                    eb.ToView("AverageSalaryByDepartment");

                    eb.Property(v => v.DepertmanId).HasColumnName("DepertmanId");
                    eb.Property(v => v.AverageSalary).HasColumnName("AverageSalary"); 
                });

            builder
                .Entity<TotalEmployees>(eb =>
                {
                    eb.HasNoKey();
                    eb.ToView("TotalEmployees");
                    eb.Property(v => v.TotalEmployeeCount).HasColumnName("TotalEmployeeCount");
                });

            builder.Entity<TotalDepartmanCount>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("TotalDepartmanCount");
                eb.Property(v => v.ActiveDepartmanCount).HasColumnName("ActiveDepartmanCount");
            });


        }
    }
}
