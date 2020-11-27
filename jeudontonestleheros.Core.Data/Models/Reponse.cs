using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    public class Reponse
    {

        #region Propriétes

        /// <summary>
        /// ID de l'instance "Reponse"
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// Description/Proposition de réponse 
        /// </summary>
        public string Description { get; set; }

        #endregion
    }
}
