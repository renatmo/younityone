using br.com.younityOne.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace br.com.younityOne.web.Controllers
{
    public class DashboardsController : BaseController
    {
        public ActionResult Dashboard_1()
        {
            Menu oMenu = new Menu();

            oMenu.Nome = "Menu1";
            
            oMenu.SubMenu = new SubMenu();
            oMenu.SubMenu.Nome = "SubMenu1";


            return View(oMenu);
        }

        public ActionResult Dashboard_2()
        {
            return View();
        }

        public ActionResult Dashboard_3()
        {
            return View();
        }
        
        public ActionResult Dashboard_4()
        {
            return View();
        }
        
        public ActionResult Dashboard_4_1()
        {
            return View();
        }

        public ActionResult Dashboard_5()
        {
            return View();
        }

    }
}