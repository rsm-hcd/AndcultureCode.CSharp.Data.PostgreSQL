using Microsoft.EntityFrameworkCore;
using AndcultureCode.CSharp.Data.PostgreSQL.Maps;

namespace AndcultureCode.CSharp.Data.PostgreSQL.Extensions
{
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// Add mapping for the given entity type
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="builder"></param>
        /// <param name="map"></param>
        public static void AddMapping<TEntity>(this ModelBuilder builder, Map<TEntity> map)
        where TEntity : class
        {
            builder.Entity<TEntity>(map.Configure);
        }

    }
}