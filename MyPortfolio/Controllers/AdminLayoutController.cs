using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
       
        public PartialViewResult AdminLayoutSideBar()
        {
            return PartialView();
        }

        public PartialViewResult AdminLayoutHead() 
        {
            return PartialView();
        }



    }
}