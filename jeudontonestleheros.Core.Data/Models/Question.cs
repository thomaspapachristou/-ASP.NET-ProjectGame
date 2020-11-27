using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    public class Question
    {
        #region Propriétés

        /// <summary>
        /// ID de l'instance "Question"
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Titre de la question  
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Liste des réponses pour la question
        /// </summary>
        public List<Reponse> MesReponses { get; set; }

        #endregion
    }
}
