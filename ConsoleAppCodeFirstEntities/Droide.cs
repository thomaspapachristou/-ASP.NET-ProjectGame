using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleAppCodeFirstEntities
{
    [Table("Droide")]
    public class Droide
    {
        /// <summary>
        ///  L'instance  ID en base de donnée est une primary key tandis que le ID de l'arme est une foreign key.
        /// </summary>
        public int ID { get; set; }

        public string Matricule { get; set; }

       // public Arme Arme { get; set; }
    }
}
