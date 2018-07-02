using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMTI.Controllers
{
    public class FinanceiroController : Controller
    {
        // GET: ContaPagar
        [Authorize]
        public ActionResult ContaPagar()
        {
            return View();
        }

        // Get: ContaReceber
        [Authorize]
        public ActionResult ContaReceber()
        {
            return View();
        }
    }
}