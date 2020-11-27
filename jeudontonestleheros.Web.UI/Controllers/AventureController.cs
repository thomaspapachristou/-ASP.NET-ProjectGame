using jeudontonestleheros.Web.UI.Models;
using jeudontonestleheros.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {

        private readonly DefaultContext _context = null;

        public AventureController(DefaultContext context)
        {
            this._context = context;
        }

        public IActionResult Index() // On pourrait écrire en paramètre [FromServices] DefaultContext context pour définir la dépendance à l'intérieur et retirer private readonly mais NON sécurisé.
        {
            this.ViewBag.monTitre = "Aventures xD";

            var query = from item in this._context.Aventures
                                       select item;

           return View(query.ToList());
        }
    }
}
