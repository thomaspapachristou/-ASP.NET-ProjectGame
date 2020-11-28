using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Paragraphe")]
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

        [NotMapped]
        public Question MaQuestion { get; set; }

        #endregion

    }
}
