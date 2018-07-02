using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMTI.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: RelacaoParceiro
        [Authorize]
        public ActionResult RelacaoParceiro()
        {
            return View();
        }
        // GET: RelacaoVenda
        [Authorize]
        public ActionResult RelacaoVenda()
        {
            return View();
        }
        // GET: RelacaoCompra
        [Authorize]
        public ActionResult RelacaoCompra()
        {
            return View();
        }
        // GET: RelacaoProduto
        [Authorize]
        public ActionResult RelacaoProduto()
        {
            return View();
        }
        // GET: RelacaoVendedor
        [Authorize]
        public ActionResult RelacaoVendedor()
        {
            return View();
        }
        // GET: Kardex
        [Authorize]
        public ActionResult Kardex()
        {
            return View();
        }
        // GET: PosicaoEstoque
        [Authorize]
        public ActionResult PosicaoEstoque()
        {
            return View();
        }
    }
}