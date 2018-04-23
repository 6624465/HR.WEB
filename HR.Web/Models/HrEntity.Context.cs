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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
        public virtual DbSet<HolidayList> HolidayLists { get; set; }
        public virtual DbSet<EmployeeDocumentDetail> EmployeeDocumentDetails { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Leave> Leaves { get; set; }
        public virtual DbSet<LeaveTransaction> LeaveTransactions { get; set; }
        public virtual DbSet<EmployeeLeaveList> EmployeeLeaveLists { get; set; }
        public virtual DbSet<Contribution> Contributions { get; set; }
        public virtual DbSet<SalaryRuleDetail> SalaryRuleDetails { get; set; }
        public virtual DbSet<SalaryRuleHeader> SalaryRuleHeaders { get; set; }
        public virtual DbSet<SalaryRuleInput> SalaryRuleInputs { get; set; }
        public virtual DbSet<WeekendPolicy> WeekendPolicies { get; set; }
        public virtual DbSet<SalaryStructureDetail> SalaryStructureDetails { get; set; }
        public virtual DbSet<SalaryStructureHeader> SalaryStructureHeaders { get; set; }
        public virtual DbSet<EmpSalaryStructureHeader> EmpSalaryStructureHeaders { get; set; }
        public virtual DbSet<EmpSalaryStructureDetail> EmpSalaryStructureDetails { get; set; }
        public virtual DbSet<OtherLeave> OtherLeaves { get; set; }
        public virtual DbSet<LeaveTran> LeaveTrans { get; set; }
        public virtual DbSet<TravelClaimDetail> TravelClaimDetails { get; set; }
        public virtual DbSet<TravelClaimHeader> TravelClaimHeaders { get; set; }
        public virtual DbSet<EmployeeBankdetail> EmployeeBankdetails { get; set; }
        public virtual DbSet<PayslipBatchDetail> PayslipBatchDetails { get; set; }
        public virtual DbSet<PayslipBatchHeader> PayslipBatchHeaders { get; set; }
        public virtual DbSet<VariablePaymentDetail> VariablePaymentDetails { get; set; }
        public virtual DbSet<VariablePaymentHeader> VariablePaymentHeaders { get; set; }
    
        public virtual ObjectResult<usp_EmployeeDateOfJoiningDate_Result> usp_EmployeeDateOfJoiningDate(Nullable<System.DateTime> currentDt, Nullable<int> branchId)
        {
            var currentDtParameter = currentDt.HasValue ?
                new ObjectParameter("CurrentDt", currentDt) :
                new ObjectParameter("CurrentDt", typeof(System.DateTime));
    
            var branchIdParameter = branchId.HasValue ?
                new ObjectParameter("BranchId", branchId) :
                new ObjectParameter("BranchId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_EmployeeDateOfJoiningDate_Result>("usp_EmployeeDateOfJoiningDate", currentDtParameter, branchIdParameter);
        }
    
        public virtual int usp_EmployeeDetailSearch(Nullable<int> branchId, string employeeName, Nullable<System.DateTime> dOJ, Nullable<int> designation, Nullable<int> type)
        {
            var branchIdParameter = branchId.HasValue ?
                new ObjectParameter("BranchId", branchId) :
                new ObjectParameter("BranchId", typeof(int));
    
            var employeeNameParameter = employeeName != null ?
                new ObjectParameter("EmployeeName", employeeName) :
                new ObjectParameter("EmployeeName", typeof(string));
    
            var dOJParameter = dOJ.HasValue ?
                new ObjectParameter("DOJ", dOJ) :
                new ObjectParameter("DOJ", typeof(System.DateTime));
    
            var designationParameter = designation.HasValue ?
                new ObjectParameter("Designation", designation) :
                new ObjectParameter("Designation", typeof(int));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EmployeeDetailSearch", branchIdParameter, employeeNameParameter, dOJParameter, designationParameter, typeParameter);
        }
    
        public virtual ObjectResult<usp_EmployeeDetail_Result3> usp_EmployeeDetail(Nullable<int> branchId, string role)
        {
            var branchIdParameter = branchId.HasValue ?
                new ObjectParameter("branchId", branchId) :
                new ObjectParameter("branchId", typeof(int));
    
            var roleParameter = role != null ?
                new ObjectParameter("role", role) :
                new ObjectParameter("role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_EmployeeDetail_Result3>("usp_EmployeeDetail", branchIdParameter, roleParameter);
        }
    }
}
