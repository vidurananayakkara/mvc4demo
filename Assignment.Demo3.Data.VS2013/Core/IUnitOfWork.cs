using System;
using Assignment.Demo3.Model.VS2013.Core;

namespace Assignment.Demo3.Data.VS2013.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        IRepository<T> GetEntityRepository<T>() where T : class, IIdentifier;
        TR GetCustomRepository<TR>() where TR : class;
        void RegisterEntityRepository<TE>(IRepository<TE> repository) where TE : class, IIdentifier
;
        void RegisterCustomRepository<TR>(TR repository) where TR : class;
    }
}
