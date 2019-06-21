using GameStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStoreApp.Controllers
{
    public class StoreController : Controller
    {
        GameStoreEntities storeDB = new GameStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            var categories = storeDB.Categories.ToList();
            var sth = storeDB.Categories.ToList();
            return View(categories);
        }

        public ActionResult Browse(string category)
        {
            var categoryModel = storeDB.Categories.Include("Games").Single(g => g.Name == category);
            return View(categoryModel);
        }
        public ActionResult Details(int id)
        {
            var game = storeDB.Games.Find(id);
            return View(game);
        }
    }
}