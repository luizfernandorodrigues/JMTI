using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMTI.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: CadastroProduto
        [Authorize]
        public ActionResult CadastroProduto()
        {
            return View();
        }
        // GET: CadastroFamilia
        [Authorize]
        public ActionResult CadastroFamilia()
        {
            return View();
        }
        // GET: LocalEstoque
        [Authorize]
        public ActionResult LocalEstoque()
        {
            return View();
        }
        // GET: CadastroNcm
        [Authorize]
        public ActionResult CadastroNcm()
        {
            return View();
        }
        // GET: CadastroCest
        [Authorize]
        public ActionResult CadastroCest()
        {
            return View();
        }
        // GET: MovimentoEstoque
        [Authorize]
        public ActionResult MovimentoEstoque()
        {
            return View();
        }
    }
}