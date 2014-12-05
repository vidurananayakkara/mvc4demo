using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Assignment.Demo3.Model.VS2013.Core;

namespace Assignment.Demo3.Data.VS2013.Core
{
    public class Repository<T> : IRepository<T> where T : class, IIdentifier
    {

        protected DbContext Context { get; set; }
        internal DbSet<T> EntitySet { get; set; }

        public Repository(DbContext context)
        {
            Context = context;
            EntitySet = context.Set<T>();
        }


        public virtual IQueryable<T> GetAll()
        {
            return EntitySet.AsQueryable();

        }


        public T GetById(int id)
        {
            return EntitySet.Find(id);
        }

        public virtual T InsertOrUpdate(T entity)
        {

            T ret;
            if (entity.Id == 0)
            {
                ret = EntitySet.Add(entity);
            }
            else
            {
                return Update(entity);
            }
            return ret;
        }

        public virtual T Delete(T entityToDelete)
        {
            throw new NotImplementedException(); // Deletion not implemented
        }

        public virtual T Update(T entityToUpdate)
        {
            try
            {
                var ret = EntitySet.Attach(entityToUpdate);
                Context.Entry(entityToUpdate).State = EntityState.Modified;
                return ret;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entry = ex.Entries.Single();
                var clientValues = (T)entry.Entity;
                var databaseValues = (T)entry.GetDatabaseValues().ToObject();

                throw;
            }
        }
    }

}
