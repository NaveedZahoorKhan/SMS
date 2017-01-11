﻿using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;

namespace VMS.DAL.Infrastructure
{
    public class CheckAndMigrateDatabaseToLatestVersion<TContext, TMigrationConfiguration> : IDatabaseInitializer<TContext> where TContext : DbContext where TMigrationConfiguration : DbMigrationsConfiguration<TContext>, new()
    {
        public void InitializeDatabase(TContext context)
        {
            //var migratorBase = ((MigratorBase)new DbMigrator(Activator.CreateInstance<TMigrationConfiguration>()));
            //if (migratorBase.GetPendingMigrations().Any())
            //    migratorBase.Update();
        }
    }
}