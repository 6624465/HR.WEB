﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HR.Web.Helpers;

namespace HR.Web.Controllers
{
    [SessionFilter]
    [ErrorHandler]
    public class MasterController : BaseController
    {
        // GET: Master
        public ActionResult List()
        {
            return View();
        }
    }
}