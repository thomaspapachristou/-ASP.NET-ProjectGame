using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure  
    {
        #region Propriétés
        /// <summary>
        /// Ceci est l'ID de chaque aventure
        /// </summary>
        
        public int Id { get; set;}

        /// <summary>
        /// Ceci est le Titre de chaque aventure
        /// </summary>
        public string Titre { get; set;}

        #endregion

    } 
}
