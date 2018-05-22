using Placovu.Erp.EntityModel;
using Placovu.Erp.IManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Placovu.Erp.Web.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        private IBSECompanyManager _iBSECompanyManager;

        public CompanyController(IBSECompanyManager iBSECompanyManager) {
            _iBSECompanyManager = iBSECompanyManager;
        }
        public ActionResult Index()
        {
            var t = _iBSECompanyManager.GetBSECompany();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BSECompany model)
        {
            var t = _iBSECompanyManager.InsertBSECompanyAsync(model);
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _iBSECompanyManager.GetBSECompany(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]        
        public async Task<ActionResult> Edit(BSECompany model)
        {
            var t = await _iBSECompanyManager.UpdateBSECompanyAsync(model);
            return View();
        }
    }
}