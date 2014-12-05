using Assignment.Demo3.Data.VS2013.Core;

namespace Assignment.Demo3.Data.VS2013
{
    public static class UowFactory
    {
        public static IUnitOfWork Create(string connectionStringName)
        {
            var context = new DatabaseContext(connectionStringName);
            var uow = new UnitOfWork(context);

            // Sample code
            //register any extended entity repository or custom repositories
            //uow.RegisterEntityRepository<Product>(new ProductRepository(context));

            return uow;
        }
    }
}
