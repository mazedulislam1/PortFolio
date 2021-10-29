using Autofac;
using BdA.SocialNetWork.Core.Contexts;
using BdA.SocialNetWork.Core.Repositories;
using BdA.SocialNetWork.Core.Services;
using BdA.SocialNetWork.Core.UnitOfWorks;
using Microsoft.Extensions.Configuration;

namespace BdA.SocialNetWork.Core
{
    public class CoreModule : Module
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;
        private readonly string migrationAssemblyName;

        public CoreModule(IConfiguration configuration, string connectionString, string migrationAssemblyName)
        {
            this.configuration = configuration;
            this.connectionString = connectionString;
            this.migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SocialContext>()
                  .WithParameter("connectionString", connectionString)
                  .WithParameter("migrationAssemblyName", migrationAssemblyName)
                  .InstancePerLifetimeScope();

            builder.RegisterType<SocialContext>().As<ISocialContext>()
                   .WithParameter("connectionString", connectionString)
                   .WithParameter("migrationAssemblyName", migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<PostUnitOfWork>().As<IPostUnitOfWork>()
                   .WithParameter("connectionString", connectionString)
                   .WithParameter("migrationAssemblyName", migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<PostRepository>().As<IPostRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PostService>().As<IPostService>()
                .InstancePerLifetimeScope();
            builder.RegisterBuildCallback(c => c.Resolve<IPostService>());

            base.Load(builder);
        }
    }
}
