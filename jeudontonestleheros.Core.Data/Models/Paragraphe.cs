using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Ajout de la fonctionnalité [Key] pour définir les PK pour EF.
using System.ComponentModel.DataAnnotations.Schema; // Ajout de la fonctionnalité [Table ""] pour EF.
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Paragraphe")] // Il va chercher le nom de table et non celui qui se trouve dans notre DefaultContext avec un "S".
    public class Paragraphe
    {
        #region Propriétés

        /// <summary>
        /// Ceci est l'ID de l'instance "Paragraphe" [PK]
        /// </summary>
        [Key]
        public int Id { get; set; }

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
        // [NotMapped]
        public Question MaQuestion { get; set; }

        #endregion

    }
}
