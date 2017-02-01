using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class StoreController : Controller
    {
        GameStoreEntities storeDB = new GameStoreEntities();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }
        //
        // GET
        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Games from database
            var genreModel = storeDB.Genres.Include("Games").Single(g => g.Name == genre);

            return View(genreModel);
        }
        //
        // GET
        public ActionResult Details(int id)
        {
            var game = storeDB.Games.Find(id);

            return View(game);
        }
        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView(genres);
        }
    }
}