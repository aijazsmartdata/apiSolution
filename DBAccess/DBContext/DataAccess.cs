using DBAccess.Entities;
using DomainService.AppSetting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DBAccess.DBContext
{
    public class DataAccess : DbContext
    {
        private readonly IOptions<ConnectionStrings> connectionStrings;

        public DataAccess(IOptions<ConnectionStrings> connectionStrings,
            DbContextOptions<DataAccess> options) : base(options)
        {
            this.connectionStrings = connectionStrings;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var options = new DbContextOptionsBuilder<DataAccess>()
         //     .UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
         .EnableSensitiveDataLogging()
         .Options;

        }
        public DbSet<User> Users { get; set; }
        
    }
}
