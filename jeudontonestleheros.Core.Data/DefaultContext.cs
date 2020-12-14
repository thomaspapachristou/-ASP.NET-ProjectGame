using System;
using System.Collections.Generic;
using System.Text;
using jeudontonestleheros.Core.Data.Models; // Le dossier models pour les DbSet avec EF
using Microsoft.EntityFrameworkCore;

namespace jeudontonestleheros.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) { }

        protected DefaultContext()
        {
        }

        #region Properties

        public DbSet<Aventure> Aventures { get; set; }
        public DbSet<Paragraphe> Paragraphes { get; set; }

        #endregion
    }
}
