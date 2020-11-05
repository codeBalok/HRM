using EasyHRM.Core.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHRM.Data.HRMdbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        }
       
        public DbSet<DepartmentModel> Depertments { get; set; }
        public DbSet<DesignationModel> Designations { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<CompanyModel> Company { get; set; }
        public DbSet<HolidayModel> Holidays { get; set; }
        public DbSet<AwardModel> Awards { get; set; }
        public DbSet<NoticeModel> Notices { get; set; }
        public DbSet<AttendenceModel> Attendences { get; set; }
        public DbSet<LeaveGroupModel> LeaveGroup { get; set; }
        public DbSet<LeaveEmployeeModel> LeaveEmployee { get; set; }


        public DbSet<LeaveTypeModel> LeaveType { get; set; }
        public DbSet<LeaveApplicationModel> LeaveApplication { get; set; }

        public DbSet<AllowanceTypeModel> AllowanceType { get; set; }
        public DbSet<AllowanceModel> Allowance { get; set; }
        public DbSet<AllowanceEmployeeModel> AllowanceEmployee { get; set; }

        public DbSet<PaySlipModel> PaySlip{ get; set; }
        public DbSet<EmployeePaySlipModel> EmployeePaySlip { get; set; }
        public DbSet<PaySlipAllowanceModel> PaySlipAllowance { get; set; }

        public DbSet<UserModel> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>()
                .HasOne(x => x.DepertmentModel)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
