using System;
using AndcultureCode.CSharp.Core.Interfaces.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using AndcultureCode.CSharp.Data.PostgreSQL.Repositories;

namespace AndcultureCode.CSharp.Data.PostgreSQL.Extensions.Startup
{
    public static class IServiceCollectionExtensions
    {
        public static void AddPostgres(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }

}