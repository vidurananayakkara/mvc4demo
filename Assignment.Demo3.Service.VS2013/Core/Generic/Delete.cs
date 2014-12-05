using Assignment.Demo3.Model.VS2013.Core;

namespace Assignment.Demo3.Service.VS2013.Core.Generic
{
    public class Delete<TEntity> : BaseService<TEntity, TEntity> where TEntity : class, IIdentifier
    {
        public override TEntity Execute(TEntity entity)
        {
            return UnitOfWork.GetEntityRepository<TEntity>().Delete(entity);
        }
    }
}
