using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        private List<Paragraphe> _maListe = new List<Paragraphe>()
        {
            new Paragraphe() {ID = 1, Numero = 1, Titre = "1 C'est cool Harry Potter xD"},
            new Paragraphe() {ID = 2, Numero = 20, Titre = "2 C'est SUPER Harry Potter xD"},
            new Paragraphe() {ID = 3, Numero = 300, Titre = "3 C'est GENIAL Harry Potter xD"}


        };

        #region Méthodes publiques

        public ActionResult Index()
        {
            return this.View();
        }
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return this.View();
        }

        public ActionResult Edit(int id)
        {
            // id (est l'int qu'on rajoute dans l'URL) =/= ID est l'instance du modèle (qu'on essaye de get/post) /!\
            Paragraphe paragraphe = null;
            paragraphe = _maListe.First(item => item.ID == id);

            return this.View(paragraphe);

        }

        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            return this.View();
        }
        #endregion


    }
}
