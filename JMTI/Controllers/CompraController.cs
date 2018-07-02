using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMTI.Controllers
{
    public class CompraController : Controller
    {
        // GET: PedidoCompra
        [Authorize]
        public ActionResult PedidoCompra()
        {
            return View();
        }
        // GET: LeXmlNota
        [Authorize]
        public ActionResult LeXmlNota()
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
            // GET: PedidoCompra
        }
    }
}