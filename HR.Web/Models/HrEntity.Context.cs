﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR.Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HrDataContext : DbContext
    {
        public HrDataContext()
            : base("name=HrDataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<EmployeeHeader> EmployeeHeaders { get; set; }
        public virtual DbSet<EmployeePersonalDetail> EmployeePersonalDetails { get; set; }
        public virtual DbSet<EmployeeWorkDetail> EmployeeWorkDetails { get; set; }
        public virtual DbSet<LookUp> LookUps { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual DbSet<LeaveDetail> LeaveDetails { get; set; }
        public virtual DbSet<LeaveHeader> LeaveHeaders { get; set; }
        public virtual DbSet<EmployeeLeaveList> EmployeeLeaveLists { get; set; }
        public virtual DbSet<HolidayList> HolidayLists { get; set; }
        public virtual DbSet<EmployeeDocumentDetail> EmployeeDocumentDetails { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
}
