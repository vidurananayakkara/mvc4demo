using Assignment.Demo3.Model.VS2013.Core;

namespace Assignment.Demo3.Service.VS2013.Core.Generic
{
    public class RetrieveById<TEntity> : BaseService<int, TEntity> where TEntity : class, IIdentifier
    {
        public override TEntity Execute(int id)
        {
            return UnitOfWork.GetEntityRepository<TEntity>().GetById(id);
        }
    }
}
