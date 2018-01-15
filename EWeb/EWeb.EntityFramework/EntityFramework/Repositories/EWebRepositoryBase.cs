using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace EWeb.EntityFramework.Repositories
{
    public abstract class EWebRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<EWebDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected EWebRepositoryBase(IDbContextProvider<EWebDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class EWebRepositoryBase<TEntity> : EWebRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected EWebRepositoryBase(IDbContextProvider<EWebDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
