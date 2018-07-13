using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JMTI.Models;

namespace JMTI.Controllers
{
    public class CadastroController : Controller
    {
        private static List<PaisModel> listaPais = new List<PaisModel>()
        {
            new PaisModel(){id=1, nome="Brasil", codigo="1058"},
            new PaisModel(){id=2, nome="Argentina", codigo="1234"},
            new PaisModel(){id=3, nome="Uruguai", codigo="7898"},
            new PaisModel(){id=4, nome="Peru", codigo="8745"},
        };
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
            return View(listaPais);
        }

        [HttpPost]
        [Authorize]
        public ActionResult RecuperarPais(int id)
        {
             return Json(listaPais.Find(x => x.id == id));
        }

        [HttpPost]
        [Authorize]
        public ActionResult ExcluirPais(int id)
        {
            var ret = false;
            var registro = listaPais.Find(x => x.id == id);
            if(registro != null)
            {
                listaPais.Remove(registro);
                ret = true;
            }
            return Json(ret);
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