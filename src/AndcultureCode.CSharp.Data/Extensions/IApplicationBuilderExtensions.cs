using System;
using AndcultureCode.CSharp.Core;
using AndcultureCode.CSharp.Core.Constants;
using AndcultureCode.CSharp.Core.Interfaces;
using AndcultureCode.CSharp.Data.Interfaces;
using AndcultureCode.CSharpCore.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AndcultureCode.CSharp.Data.Extensions
{
    /// <summary>
    /// Infrastructure Data IApplicationBuilder Extensions
    /// </summary>
    public static class IApplicationBuilderExtensions
    {
        #region Public Methods

        /// <summary>
        /// Performs application startup related database configuration tasks
        /// </summary>
        /// <param name="app"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="migrate">Should outstanding code-first migrations be run?</param>
        /// <param name="seeds">Optional instance of seeds to run</param>
        public static void ConfigureDatabase<TContext>(
            this IApplicationBuilder app,
            IServiceProvider serviceProvider,
            bool migrate = true,
            SeedsBase<TContext> seeds = null
        )
            where TContext : class, IDatabaseContext
        {
            var env = serviceProvider.GetService<IHostEnvironment>();
            if (env.IsEnvironment(EnvironmentConstants.TESTING))
            {
                return;
            }

            var context = serviceProvider.GetService<TContext>();
            var logger = serviceProvider.GetService<ILogger<IApplicationBuilder>>();

            if (migrate)
            {
                Migrate(context.Database, logger);
            }

            if (seeds != null)
            {
                Seed(seeds, logger);
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static void Migrate(DatabaseFacade database, ILogger<IApplicationBuilder> logger)
        {
            logger.LogInformation("Migrating database...");
            database.SetCommandTimeout(int.MaxValue);
            database.Migrate();
            logger.LogInformation("Database migrated");
        }

        private static void Seed<TContext>(SeedsBase<TContext> seeds, ILogger<IApplicationBuilder> logger)
            where TContext : class, IDatabaseContext
        {
            logger.LogInformation("Seeding database...");
            seeds.Create();
            logger.LogInformation("Database seeded");
        }

        #endregion Private Methods
    }
}
