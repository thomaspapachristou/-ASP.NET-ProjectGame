using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace ConsoleAppCodeFirstEntities
{
    /// <summary>
    /// Contexte sera l'espace mémoire entre l'ORM (Entity) et notre serveur. Obligatoire d'avoir un DefaultContext.cs avec deux constructeurs pour la mise en place Entity.
    /// </summary>
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options){}

        protected DefaultContext() {}

        public DbSet<Droide> Droides { get; set; }
    }
}

    /// <summary>
/// [/!\] Formalisme à respecter pour créer les entities Dbset<Entity> - Il faut ensuite set-up les deux constructeurs sur Program.cs : ConfigurationBuilder et OptionsBuilder.
/// </summary>