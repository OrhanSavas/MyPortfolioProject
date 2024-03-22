using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        MyAcademyPortfolioProjectEntities db = new MyAcademyPortfolioProjectEntities();
        public ActionResult Index()
        {
            var values = db.TblProjects.ToList();
            return View(values);
        }

        public ActionResult AddProject() 
        {
            var categories = db.TblCategories.ToList();

            List<SelectListItem> categoryList = (from x in categories select new SelectListItem
            {
                Text=x.CategoryName,
                Value=x.CategoryId.ToString()
            }).ToList();

            ViewBag.category = categoryList;

            return View();
        }

        [HttpPost]
        public ActionResult AddProject(TblProjects project)
        {
            db.TblProjects.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}