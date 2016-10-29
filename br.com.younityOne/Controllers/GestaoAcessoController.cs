using br.com.younityOne.BLL;
using br.com.younityOne.MODEL;
using br.com.younityOne.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace br.com.younityOne.web.Controllers
{
    public class GestaoAcessoController : Controller
    {
        GestaoAcessoBLL oGestaoAcessoBLL = new GestaoAcessoBLL();

        // GET: GestaoAcesso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult obterMenu() 
        {
            NavegacaoMODEL oNavegacaoMODEL = new NavegacaoMODEL();
            List<UsuarioMODEL> oPermissoes = (List<UsuarioMODEL>)Session["PermissoesUsuario"];

            oNavegacaoMODEL.NomeUsuario = oPermissoes.FirstOrDefault().NOM_USUARIO;
            oNavegacaoMODEL.CodigoUsuario = oPermissoes.FirstOrDefault().COD_USUARIO;

            oNavegacaoMODEL.Menu = oGestaoAcessoBLL.obterMenus(Session["CodigoUsuario"].ToString());

            return PartialView("_Navigation", oNavegacaoMODEL);
        }
    }
}