using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoardgameDatabase.Models;

namespace BoardgameDatabase.Controllers
{
    public class BoardgameController : Controller
    {
        public static List<Boardgame> data = new List<Boardgame>() { 
            new Boardgame(){Id=1,Name="Kemet",Owner="Gosha",Keeper="Valera",MaxPlayers=4,MinPlayers=2,ForSale=false,Tags=new List<string>(){"strategy","area controll"} },
            new Boardgame(){Id=2,Name="Dune",Owner="Gosha",Keeper="Gosha",MaxPlayers=6,MinPlayers=2,ForSale=false,Tags=new List<string>(){"strategy","area controll","diplomacy"} }
        }; 
        // GET: BoardgameController
        public ActionResult Index()
        {
            return View(data);
        }

        // GET: BoardgameController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BoardgameController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BoardgameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BoardgameController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BoardgameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BoardgameController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BoardgameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
