using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using FindCar.Core.Context;
using FindCar.Core.Repositories;
using FindCar.Core.Services;
using FindCar.Core.UnitOfWorks;

namespace FindCar.Core
{
    public class CoreModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public CoreModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FinderContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<FinderUnitOfWork>().As<IFinderUnitOfWork>()
                    .InstancePerLifetimeScope();

            builder.RegisterType<VehicleRepository>().As<IVehicleRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<VehicleService>().As<IVehicleService>()
                .InstancePerLifetimeScope();


            base.Load(builder);
        }
    }
}
