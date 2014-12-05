using System.Linq;
using Assignment.Demo3.Model.VS2013.Core;

namespace Assignment.Demo3.Data.VS2013.Core
{
    public interface IRepository<T> where T : class, IIdentifier
    {
        IQueryable<T> GetAll();

        T GetById(int id);

        T InsertOrUpdate(T entity);

        T Update(T entity);

        T Delete(T entity);

    }
}

