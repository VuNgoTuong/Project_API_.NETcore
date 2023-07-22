using Microsoft.EntityFrameworkCore;
using ProjectCaNhan.Entities;

namespace ProjectCaNhan.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"server=T18-VUNT\SQLEXPRESS; Database=qlnvdb;user=sa;password=Tuongvu1999; TrustServerCertificate=True");
        }
    }
}
