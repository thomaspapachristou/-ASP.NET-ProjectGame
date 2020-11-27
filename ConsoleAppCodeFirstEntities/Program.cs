using System.Linq;
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace ConsoleAppCodeFirstEntities
{
    class Program
    {
        static void Main(string[] args)
        {

            // Configuration Builder = Permet de créer la liaison avec la DB avec le code. (Entity Core)

            ConfigurationBuilder builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            /// <summary>
            /// builder.Build permet d'envoyer à un IConfigurationRoot qui va permettre de récupérer l'accès à la DB :
            /// ConnectionStrings/DefaultContext de la DB dans appsettings.json)
            /// </summary>
            
            var config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultContext");

            // Options Builder = Permet de définir quel type de serveur (Entity Core)

            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();

            optionsBuilder.UseSqlServer(connectionString);
            

            /// <summary>
            /// optionsBuilder.Options est une méthode de EntityCore qui permet de récupérer tous les paramètres pour créer la requête (query)
            /// </summary>
            using (DefaultContext context = new DefaultContext(optionsBuilder.Options))
            {
                context.Database.EnsureCreated();

                var query = from droide in context.Droides
                            select droide;
                foreach (var item in query.ToList())
                {
                    Console.WriteLine("Droide matricule " + item.Matricule);
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
