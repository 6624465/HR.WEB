﻿using HR.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace HR.Web.Controllers
{

    [SessionFilter]
    public class ConfigController : BaseController
    {
        HrDataContext dbContext = new HrDataContext();

        public ActionResult GetDesignation()
        {
            var EmployeeData = dbContext.LookUps.Where(x => x.LookUpCategory == "EmployeeDesignation").AsQueryable();
            return View(EmployeeData);
        }
       
        }
        
        public ActionResult EmpTypepaging(int page)
        {
            
                int pageSize = 5;
                int totalpages = 0;
                int totalRecords = 0;
            
            using (var dbctx = new HrDataContext())
            {

                    totalRecords = dbctx.LookUps.ToList().Count();
        
                    totalpages = (totalRecords / pageSize) + ((totalRecords % pageSize) > 0 ? 1 : 0);
   
                   var allList = dbctx.LookUps.OrderBy(a => a.LookUpID).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                return View(allList);
            }
           
        }

        #region EmployeeType
        [HttpGet]
        public ActionResult EmployeeTypeList()
        {
            
                var list = dbCntx.LookUps.Where(x => x.LookUpCategory == "EmployeeType").ToList().AsEnumerable();
                return View(list);
            
        }

        [HttpGet]

        public PartialViewResult GetEmployeeType(int lookupID)
        {
            if (lookupID != -1)
            {
                using (var dbCntx = new HrDataContext())
                {
                    var employeeType = dbCntx.LookUps.Where(x => x.LookUpID == lookupID).FirstOrDefault();
                    return PartialView(employeeType);
                }
            }
            else
                return PartialView(new LookUp { LookUpID = -1 });
        }

        [HttpPost]
        public ActionResult SaveEmployeeType(LookUp lookup)
        {
            if (lookup.LookUpID != -1)
            {
                using (var dbCntx = new HrDataContext())
                {
                    var _lookupObj = dbCntx.LookUps.Where(x => x.LookUpID == lookup.LookUpID).FirstOrDefault();

                    _lookupObj.LookUpCode = lookup.LookUpCode;
                    _lookupObj.LookUpDescription = lookup.LookUpDescription;
                    _lookupObj.ModifiedBy = USERID;
                    _lookupObj.ModifiedOn = DateTime.Now;

                    dbCntx.SaveChanges();
                }
            }
            else
            {
                using (var dbCntx = new HrDataContext())
                {
                    var lookupObj = new LookUp
                    {
                        LookUpCode = lookup.LookUpCode,
                        LookUpDescription = lookup.LookUpDescription,
                        LookUpCategory = UTILITY.CONFIG_EMPLOYEETYPE,
                        IsActive = true,
                        CreatedOn = DateTime.Now,
                        CreatedBy = USERID,
                        ModifiedOn = DateTime.Now,
                        ModifiedBy = USERID
                    };

                    dbCntx.LookUps.Add(lookupObj);
                    dbCntx.SaveChanges();
                }

            }
            return RedirectToAction("EmployeeTypeList");
        }

        #endregion
        public ActionResult EmployeeDepartmentList()
        {
            using (var dbCntx = new HrDataContext())
            {
                var list = dbCntx.LookUps.Where(x => x.LookUpCategory == "EmployeeDepartment").AsQueryable();
                return View(list);
            }
                
        }
    }
}