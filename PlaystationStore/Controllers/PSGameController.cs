using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaystationStore.Models;
using PlaystationStore.Models.Repositories;

namespace PlaystationStore.Controllers
{
    public class PSGameController : Controller
    {
        //PSGameStoreDbContext context = new PSGameStoreDbContext();
        PSGameStoreDbContext db = new PSGameStoreDbContext();
        GameRepository repository = new GameRepository();
            // GET: PSGame
        public PSGameController()
        {
            Console.WriteLine();
        }
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()] //only two same name method can be created in one controller and one should be HTTPGET one HTTPPOST.
        public ActionResult Create(Game game)
        {
            if (!ModelState.IsValid) return View(game);

            repository.Add(game);
            repository.SaveChanges();
            return RedirectToAction("Index"); 
        }
        public ActionResult Delete(Game game)
        {

            repository.Delete(game);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(GameEditViewModel gameEditViewModel)
        {
            if (ModelState.IsValid)
            {
                var game = new Game()
                {
                    gameID = gameEditViewModel.gameID,
                    gameGeneric = gameEditViewModel.gameGeneric,
                    gameName = gameEditViewModel.gameName,
                    gamePrice = gameEditViewModel.gamePrice

                };
                //db.Entry(game).State = System.Data.Entity.EntityState.Modified;
            }
            return View();
        }
    }

}