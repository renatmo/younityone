using br.com.younityOne.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace br.com.younityOne.web.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        #region Constructors
        public BaseController() : base() { }
        #endregion

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            var _controller_name = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            var _action_name = filterContext.ActionDescriptor.ActionName;

            List<UsuarioMODEL> listaUsuarioMODEL = (List<UsuarioMODEL>)Session["PermissoesUsuario"];

            if (listaUsuarioMODEL == null || listaUsuarioMODEL.Count == 0)
            {
                filterContext.Result = new ViewResult() { ViewName = "SemPermissao" };
            }
            else
            {
                if (listaUsuarioMODEL.Any(p => p.NOM_ACTION == _action_name && p.NOM_CONTROLLER == _controller_name) == false)
                {
                    filterContext.Result = new ViewResult() { ViewName = "SemPermissao" };
                }
                else
                {
                    // Gravar Log

                }
            }

        }

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }

    }
}