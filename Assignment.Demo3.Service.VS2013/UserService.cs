using System.Linq;
using Assignment.Demo3.Data.VS2013.Repos;
using Assignment.Demo3.Model.VS2013.Entities;
using Assignment.Demo3.Service.VS2013.Core;

namespace Assignment.Demo3.Service.VS2013
{
    public class UserService : BaseService<int, IQueryable<User>>
    {
        public IQueryable<User> GetAllUsers()
        {
            return UnitOfWork.GetCustomRepository<UserRepository>().GetAll();
        }

        public override IQueryable<User> Execute(int request)
        {
            throw new System.NotImplementedException();
        }
    }
}
