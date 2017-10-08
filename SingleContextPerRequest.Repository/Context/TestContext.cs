using SingleContextPerRequest.Repository.Context.Model;
using System.Data.Entity;

namespace SingleContextPerRequest.Repository.Context
{
    public class TestContext : DbContext
    {
        public TestContext() : base("Local")
        {
            
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Car> Car { get; set; }
    }
}
