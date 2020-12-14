using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Voir Commentaire dans Paragraphe.cs
using System.ComponentModel.DataAnnotations.Schema; // Voir commentaire dans Paragraphe.cs
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    public class Question
    {
        #region Propriétés

        /// <summary>
        /// ID de l'instance "Question" [PK]
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Titre de la question  
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Ceci est la liaison Master/Slave entre les models Paragraphe.cs et Question.cs
        /// </summary>
        public int ParagrapheId { get; set; }

        /// <summary>
        /// Liste des réponses pour la question
        /// </summary>
        [NotMapped]
        public List<Reponse> MesReponses { get; set; }

        #endregion
    }
}
