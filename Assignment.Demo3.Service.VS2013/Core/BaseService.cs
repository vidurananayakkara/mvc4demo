using Assignment.Demo3.Data.VS2013;
using Assignment.Demo3.Data.VS2013.Core;

namespace Assignment.Demo3.Service.VS2013.Core
{
    public abstract class BaseService<TRequest, TResponse>
    {
        public IUnitOfWork UnitOfWork { get; set; }

        protected BaseService()
        {
            UnitOfWork = UowFactory.Create("DemoDb");
        }

        public abstract TResponse Execute(TRequest request);
    }
}
