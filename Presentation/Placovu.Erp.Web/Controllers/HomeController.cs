using log4net.Core;
using Placovu.Erp.IManager;
using Placovu.Erp.Web.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace Placovu.Erp.Web.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private IBSECompanyManager _iBSECompanyManager;
        
        public HomeController(IBSECompanyManager iBSECompanyManager)
        {
            _iBSECompanyManager = iBSECompanyManager;
        }
        public ActionResult Index()
        {
            try
            {
                return new HttpNotFoundResult("Database not Found.");    
                var t = _iBSECompanyManager.GetBSECompany();
            }
            catch (Exception)
            {
               throw;
            }           
            return View();

        }
        [HttpPost]
        public ActionResult Create()
        {
            try
            {
                //if (1 == 1)
                //{
                //    return new HttpNotFoundResult("ssssssssssssssss");
                //}
                var rt = Convert.ToInt16("rtyrty");
                var t = _iBSECompanyManager.GetBSECompany();
            }
            catch (Exception)
            {
                throw;
            }
            return View();

        }

        public ActionResult Error404()
        {
            return View();
        }
    }
}
