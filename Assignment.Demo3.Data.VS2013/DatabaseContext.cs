using System.Data.Entity;
using System.Diagnostics;
using Assignment.Demo3.Data.VS2013.Core;
using Assignment.Demo3.Model.VS2013.Entities;

namespace Assignment.Demo3.Data.VS2013
{
    public class DatabaseContext : BaseContext
    {
        public DatabaseContext(string connectionStringName)
            : base(connectionStringName)
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
            Database.Log = LogDbOperations;
        }

        private static void LogDbOperations(string s)
        {
            Debug.Write(s);
        }

        // Configurations
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        // Entities
        public DbSet<User> Users { get; set; }
    }
}
