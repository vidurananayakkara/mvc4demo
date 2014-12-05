using System;
using System.Collections.Generic;
using Assignment.Demo3.Model.VS2013.Core;

namespace Assignment.Demo3.Data.VS2013.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        public BaseContext Context { get; set; }
        internal Dictionary<Type, object> RepositoryCache { get; private set; }

        public UnitOfWork(BaseContext dbContext)
        {
            RepositoryCache = new Dictionary<Type, object>();
            Context = dbContext;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Context != null)
                {
                    Context.Dispose();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetEntityRepository<T>() where T : class, IIdentifier
        {
            // Look for repository in cache 
            object repoObj;
            if (RepositoryCache.TryGetValue(typeof(IRepository<T>), out repoObj))
            {
                return (IRepository<T>)repoObj;
            }

            // Not found, add to cache, and return
            IRepository<T> repo = new Repository<T>(Context);
            RepositoryCache[typeof(IRepository<T>)] = repo;
            return repo;
        }

        public TR GetCustomRepository<TR>() where TR : class
        {
            object repoObj;
            if (RepositoryCache.TryGetValue(typeof(TR), out repoObj))
            {
                return (TR)repoObj;
            }

            // Not found, add to cache, and return      
            var repo = (TR)Activator.CreateInstance(typeof(TR), Context);
            RepositoryCache.Add(typeof(TR), repo);
            return repo;
        }

        public void RegisterEntityRepository<TE>(IRepository<TE> repo) where TE : class, IIdentifier
        {
            RepositoryCache[typeof(IRepository<TE>)] = repo;
        }

        public void RegisterCustomRepository<TR>(TR repository) where TR : class
        {
            RepositoryCache.Add(typeof(TR), repository);
        }
    }
}
