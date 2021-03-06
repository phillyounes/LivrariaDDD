using Autofac;
using AutoMapper;
using LivrariaDDD.Application.AutoMapper;
using LivrariaDDD.Application.Interfaces;
using LivrariaDDD.Application.Services;
using LivrariaDDD.CrossCutting.IoC;
using LivrariaDDD.Repository;
using LivrariaDDD.Repository.Interfaces;
using LivrariaDDD.Services;
using LivrariaDDD.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LivrariaDDD.Presentation
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
            var mappingConfig = new MapperConfiguration(x =>
            {
                x.AddProfile(new DomainToViewModelMappingProfile());
                x.AddProfile(new ViewModelToDomainMappingProfile());
                x.AllowNullCollections = true;
                x.AllowNullDestinationValues = true;
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<IAutorApp, AutorApp>();
            services.AddTransient<ILivroApp, LivroApp>();

            services.AddTransient<IAutorService, AutorService>();
            services.AddTransient<ILivroService, LivroService>();

            services.AddTransient<IAutorRepository, AutorRepository>();
            services.AddTransient<ILivroRepository, LivroRepository>();

            services.AddControllersWithViews();
        }

        //public void ConfigureContainer(ContainerBuilder Builder)
        //{
        //    #region Modulo IOC
        //    Builder.RegisterModule(new ModuleIOC());
        //    #endregion
        //}

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
