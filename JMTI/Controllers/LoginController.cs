using JMTI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace JMTI.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string retUrl)
        {
            ViewBag.ReturnUrl = retUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string retUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var achou = UsuarioModel.ValidarUsuario(login.usuario,login.senha);
            if (achou)
            {
                FormsAuthentication.SetAuthCookie(login.usuario, login.lembrarMe);
                if (Url.IsLocalUrl(retUrl))
                {
                    return Redirect(retUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Login Inválido!!");
            }
            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}