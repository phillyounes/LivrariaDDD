using Autofac;
using LivrariaDDD.Application.Interfaces;
using LivrariaDDD.Application.Services;
using LivrariaDDD.Repository;
using LivrariaDDD.Repository.Interfaces;
using LivrariaDDD.Services;
using LivrariaDDD.Services.Interfaces;
using System;

namespace LivrariaDDD.CrossCutting.IoC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<IAutorApp>().As<AutorApp>();
            builder.RegisterType<ILivroApp>().As<LivroApp>();
            #endregion

            #region IOC Services
            builder.RegisterType<IAutorService>().As<AutorService>();
            builder.RegisterType<ILivroService>().As<LivroService>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<IAutorRepository>().As<AutorRepository>();
            builder.RegisterType<ILivroRepository>().As<LivroRepository>();
            #endregion

            #endregion
        }
    }

}
