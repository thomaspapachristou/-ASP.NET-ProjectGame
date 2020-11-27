using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    public class Paragraphe
    {
        #region Propriétés

        /// <summary>
        /// Ceci est l'ID de l'instance "Paragraphe"
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Ceci le numéro  à afficher pour le jeu
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Ceci est le titre du paragraphe
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Ceci est la description du paragraphe
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Question du paragraphe
        /// </summary>
        public Question MaQuestion { get; set; }

        #endregion

    }
}
