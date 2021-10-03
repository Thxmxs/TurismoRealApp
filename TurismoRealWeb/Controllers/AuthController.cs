using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurismoRealWeb.Negocio;
using System.Web.Security;


namespace TurismoRealWeb.Controllers
{
    public class AuthController : Controller
    {


        public ActionResult Login()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Login(CuentaUsuario cuentaUsuario,string ReturnUrl)
        {
            
            
            if (IsValid(cuentaUsuario))
            {
           
                FormsAuthentication.SetAuthCookie(cuentaUsuario.emailUsuario,false);//crea una cookie
                if(ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                return RedirectToAction("Index", "Home");
            }
            
            return View(cuentaUsuario);
            
        }
        private bool IsValid(CuentaUsuario cuentaUsuario)
        {
            return cuentaUsuario.Autenticar();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }



    }
}