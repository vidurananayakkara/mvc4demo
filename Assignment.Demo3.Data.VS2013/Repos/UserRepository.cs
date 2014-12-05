using System.Data.Entity;
using Assignment.Demo3.Data.VS2013.Core;
using Assignment.Demo3.Model.VS2013.Entities;

namespace Assignment.Demo3.Data.VS2013.Repos
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(DbContext context) : base(context) { }
    }
}
