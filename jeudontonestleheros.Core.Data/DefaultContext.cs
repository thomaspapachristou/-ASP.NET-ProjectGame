using System;
using System.Collections.Generic;
using System.Text;
using jeudontonestleheros.Core.Data.Models; // Le dossier models pour les DbSet avec Entity
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

        #endregion
    }
}
