using Autofac;
using BdA.SocialNetwork.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Data
{
    public class DataModule : Module
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;
        private readonly string migrationAssemblyName;

        public DataModule(IConfiguration configuration, string connectionString, string migrationAssemblyName)
        {
            this.configuration = configuration;
            this.connectionString = connectionString;
            this.migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<Repository,IRepository>();
            //builder.RegisterGeneric(typeof(Repository<>)).AsSelf();
            builder
                .RegisterGeneric(typeof(Repository<>))
                .As(typeof(IRepository<>))
                .InstancePerDependency();
            builder
                .RegisterGeneric(typeof(UnitOfWork<>))
                .As(typeof(IUnitOfWork<>))
                .InstancePerDependency();
            base.Load(builder);
        }
    }
}
