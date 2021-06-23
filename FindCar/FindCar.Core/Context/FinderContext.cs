using System;
using System.Collections.Generic;
using System.Text;
using FindCar.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FindCar.Core.Context
{
    public class FinderContext:DbContext, IFinderContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FinderContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
