using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMTI.Controllers
{
    public class VendaController : Controller
    {
        // GET: PedidoVenda
        [Authorize]
        public ActionResult PedidoVenda()
        {
            return View();
        }
        // GET: NotaFiscal
        [Authorize]
        public ActionResult NotaFiscal()
        {
            return View();
        }
        // GET: RetornoNfe
        [Authorize]
        public ActionResult RetornoNfe()
        {
            return View();
        }
    }
}