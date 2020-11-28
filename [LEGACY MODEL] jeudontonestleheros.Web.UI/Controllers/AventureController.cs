using jeudontonestleheros.Web.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.monTitre = "Aventures xD";
            
            List<Aventure> maListe = new List<Aventure>();
            
            maListe.Add(new Aventure()
            {
                ID = 1,
                Titre = "Harry Potter à l'école des sorciers"
            });

            maListe.Add(new Aventure()
            {
                ID = 2,
                Titre = "Harry Potter et la chambre des secrets"
            });

            return View(maListe);
        }
    }
}
