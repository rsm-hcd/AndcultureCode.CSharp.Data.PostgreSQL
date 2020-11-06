using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndcultureCode.CSharp.Data.PostgreSQL.Maps
{
    public abstract class Map<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> entity);
    }
}