using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using br.com.younityOne.web.Models;
using br.com.younityOne.BLL;
using br.com.younityOne.MODEL;

namespace br.com.younityOne.web.Controllers
{
    public class PagesController : Controller
    {
        UsuarioBLL oUsuarioBll = new UsuarioBLL();

        public ActionResult SearchResults()
        {
            return View();
        }

        public ActionResult LockScreen()
        {
            return View();
        }

        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult InvoicePrint()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login_2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login_2(Usuario pUsuario)
        {
            List<UsuarioMODEL> listaUsuarioMODEL = null;

            listaUsuarioMODEL = oUsuarioBll.logar(pUsuario.CodigoUsuario, pUsuario.Senha);

            if (listaUsuarioMODEL.Count > 0)
            {
                Session["CodigoUsuario"] = pUsuario.CodigoUsuario;
                Session["PermissoesUsuario"] = listaUsuarioMODEL;

            }

            return RedirectToAction("Dashboard_1", "Dashboards");

        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult NotFoundError()
        {
            return View();
        }

        public ActionResult InternalServerError()
        {
            return View();
        }

        public ActionResult EmptyPage()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

       
	}
}