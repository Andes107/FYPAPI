using System;
using System.Collections.Generic;

namespace FYPAPI.Infrastructure.UOWRepositories
{
    public interface IRepository<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindMany(TEntity entity);
    }
}