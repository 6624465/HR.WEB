﻿using HR.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.Web.ViewModels
{

    public class AppliedLeaveListVm
    {
        public string BranchName { get; set; }
        public int BranchID { get; set; }
        public IEnumerable<EmpLeaveListVm> employeeLeaveList { get; set; }
    }
    public class LeaveVm
    {
        public LookUp lookup { get; set; }        
        public LeaveHeader leaveHeader { get; set; }
        public IEnumerable<LeaveHeaderVm> lvmList { get; set; }
       

    }

    public class EmpLeaveListVm
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Status { get; set; }
    }
    public class LeaveHeaderVm
    {
        public int LeaveHeaderID { get; set; }
        public int BranchID { get; set; }
        public Nullable<short> LeaveYear { get; set; }
        public string LeaveYearDescription { get; set; }
        
        public Nullable<int> PeriodicityType { get; set; }
        public string PeriodicityTypeDescription { get; set; }
        public Nullable<int> PeriodType { get; set; }
        public string PeriodTypeDescription { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> LeaveSchemeType { get; set; }
      
       public string LeaveSchemeTypeDescription { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }

    }
    
    public class GrantLeaveListVm
    {
        public DateTime ToDate { get; set; }

        public DateTime FromDate { get; set; }

        public string Name { get; set; }

        public int EmployeeId { get; set; }
        public string Remarks { get; set; }
        public string Reason { get; set; }

        public int EmployeeLeaveID { get; set; }

        public string Status { get; set; }

        public DateTime ApplyDate { get; set; }

        public string LeaveTypeDesc { get; set; }

        public decimal? TotalDays { get; set; }

    }

    public class ViewLeaveVm
    {
        public int EmployeeLeaveID { get; set; }
        public int EmployeeId { get; set; }
        public Nullable<int> LeaveTypeId { get; set; }
        public string LeaveTypeDesc { get; set; }
        public int BranchId { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public decimal? Days { get; set; }
        public string Reason { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public System.DateTime ApplyDate { get; set; }
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
    }
    public class LeavepolicyVm
    {
        public int LeaveId { get; set; }
        public int? PaidLeavesPerYear { get; set; }
        public decimal? PaidLeavesPerMonth { get; set; }
        public bool IsPaidLeaveCarryForward { get; set; }
        public decimal? CarryFarwardPerYear { get; set; }
        public int? SickLeavesPerYear { get; set; }
        public decimal? SickLeavesPerMonth { get; set; }
        public bool IsSickLeaveCarryFarward { get; set; }
        public decimal? CarryFarwardSickLeaves { get; set; }
        public int? CasualLeavesPerYear { get; set; }
        public decimal? CasualLeavesPerMonth { get; set; }
        public bool IsCasualLeaveCarryFarward { get; set; }
        public Int64? BranchId { get; set; }
        public string BranchName { get; set; }



    }
    


}