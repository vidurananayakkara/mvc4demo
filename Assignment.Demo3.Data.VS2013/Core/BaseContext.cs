using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Assignment.Demo3.Data.VS2013.Core
{
    public class BaseContext : DbContext
    {
        public BaseContext(string connectionStringName) : base(connectionStringName) { }

        /// <summary>
        /// EF new versions hide operations such as 'Detach' from being exposed. If one need to change
        /// state of an object he may use this method to go so.
        /// </summary>
        /// <param name="entity">entity to change state</param>
        /// <param name="entityState">new state</param>
        public void ChangeObjectState(object entity, EntityState entityState)
        {
            ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager.ChangeObjectState(entity, entityState);
        }

    }
}
