using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMTI.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Parceiro
        [Authorize]
        public ActionResult Parceiro()
        {
            return View();
        }
        // GET: Vendedor
        [Authorize]
        public ActionResult Vendedor()
        {
            return View();
        }
        // GET: Tributacao
        [Authorize]
        public ActionResult Tributacao()
        {
            return View();
        }
        // GET: ModeloNota
        [Authorize]
        public ActionResult ModeloNota()
        {
            return View();
        }
        // GET: SerieNota
        [Authorize]
        public ActionResult SerieNota()
        {
            return View();
        }
        // GET: Pais
        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }
        // GET: Estado
        [Authorize]
        public ActionResult Estado()
        {
            return View();
        }
        // GET: Cidade
        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }
        // GET: Cep
        [Authorize]
        public ActionResult Cep()
        {
            return View();
        }
        // GET: GrupoUsuario
        [Authorize]
        public ActionResult GrupoUsuario()
        {
            return View();
        }
        // GET: Usuario
        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }
    }
}