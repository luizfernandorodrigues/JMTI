using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMTI.Controllers
{
    public class GraficoController : Controller
    {
        // GET: VendaVendedor
        [Authorize]
        public ActionResult VendaVendedor()
        {
            return View();
        }
        // GET: VendaCidade
        [Authorize]
        public ActionResult VendaCidade()
        {
            return View();
        }
        // GET: CompraMes
        [Authorize]
        public ActionResult CompraMes()
        {
            return View();
        }
        // GET: VendaMes
        [Authorize]
        public ActionResult VendaMes()
        {
            return View();
        }
    }
}