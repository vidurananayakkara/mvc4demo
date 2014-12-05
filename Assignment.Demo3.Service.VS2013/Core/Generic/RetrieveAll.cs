using System.Linq;
using Assignment.Demo3.Model.VS2013.Core;

namespace Assignment.Demo3.Service.VS2013.Core.Generic
{
    public class RetrieveAll<TEntity> : BaseService<object, IQueryable<TEntity>> where TEntity : class, IIdentifier
    {
        public override IQueryable<TEntity> Execute(object request = null)
        {
            return UnitOfWork.GetEntityRepository<TEntity>().GetAll();
        }
    }
}
