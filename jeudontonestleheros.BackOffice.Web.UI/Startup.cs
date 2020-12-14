using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using jeudontonestleheros.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace jeudontonestleheros.BackOffice.Web.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            // services.AddRazorPages();

            string connectionString = this.Configuration.GetConnectionString("DefaultContext");
            services.AddDbContext<DefaultContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

            // Ajout du service de connexion Facebook (+ Package) - 
            // Récupérations des objets dans le secret.json
            services.AddAuthentication().AddFacebook(options =>
            {
                options.AppId = this.Configuration["apis:facebook:id"];
                options.AppSecret = this.Configuration["apis:facebook:secret"];
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();
            app.UseRouting();

            // Ajout des dépendances nécessaires au fonctionnement de Identity, voir le POC IdentityFacebook
            app.UseAuthentication();
            app.UseCookiePolicy();
            // Fin des dépendances Identity

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // Ajout des routes pour le scaffolding de Identity et de l'architecture MVC
                endpoints.MapControllers();
                endpoints.MapRazorPages();
                // Fin du système de route Identity

                endpoints.MapControllerRoute(
                    name: "mesaventures",
                    pattern: "mes-aventures",
                    defaults: new
                    {
                        // Dans Web UI, on utilise Aventure car on a divisé le projet en deux solutions
                        controller = "Paragraphe",
                        action = "Index"
                    });


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
