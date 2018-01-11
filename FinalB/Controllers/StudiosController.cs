using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalB.Models;

namespace FinalB.Controllers
{
    //[Authorize]
    public class StudiosController : Controller
    {
        private MovieModel db = new MovieModel();

        // GET: Studios
        public ActionResult Index()
        {
            return View(db.Studios.ToList().OrderBy(g => g.Name));
        }

        // GET: Studios/Details/5
        public ViewResult Details(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            Studio studio = db.Studios.Find(id);
            if (studio == null)
            {
                return View("Error");
            }
            return View(studio);
        }

       
    }
}
