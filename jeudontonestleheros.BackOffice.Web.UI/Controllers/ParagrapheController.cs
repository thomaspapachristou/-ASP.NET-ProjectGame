using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region Private Area xD

        private readonly DefaultContext _context = null;

        #endregion

        #region Constructors

        public ParagrapheController(DefaultContext context)
        {
            this._context = context; 
        }

        #endregion

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
            this._context.Paragraphes.Add(paragraphe);
            this._context.SaveChanges();

            return this.View();
        }

        public ActionResult Edit(int id)
        {
            // id (est l'int qu'on rajoute dans l'URL) =/= ID est l'instance du modèle (qu'on essaye de get/post) /!\
            Paragraphe paragraphe = null;
            paragraphe = this._context.Paragraphes.First(item => item.Id == id);

            return this.View(paragraphe);

        }

        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            // [this._context.Paragraphes.Update(paragraphe);] --> Modification de la totalité de Paragraphe

            // Si on veut modifier un paramètre en particulier d'une colonne, on écrit comme ci-dessous
            // On attache l'objet pour le suivre/tracker par EF 
            this._context.Attach<Paragraphe>(paragraphe);

            // On définie lesquels attribut qui seront modifiés sur le client.
            this._context.Entry(paragraphe).Property(item => item.Titre).IsModified = true;
            this._context.Entry(paragraphe).Property(item => item.Description).IsModified = true;

            this._context.SaveChanges();

            return this.View();
        }
        #endregion


    }
}
