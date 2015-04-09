using DataAccess.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataAccess.DAL
{
    public class DataAccessContext : IdentityDbContext<ApplicationUser>
    {
        public DataAccessContext() : base("DataAccessContext", throwIfV1Schema: false) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Institution> Institutions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public static DataAccessContext Create()
        {
            return new DataAccessContext();
        }
    }
}