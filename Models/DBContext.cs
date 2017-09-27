using Microsoft.EntityFrameworkCore;

namespace BrahmaServer.Models
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {            
        }

        public DbSet<BrahmaServer.Models.Employee> Employee { get; set; }
        public DbSet<BrahmaServer.Models.Certification> Certification { get; set; }
        public DbSet<BrahmaServer.Models.Contact> Contact { get; set; }
        public DbSet<BrahmaServer.Models.Notification> Notification { get; set; }
        public DbSet<BrahmaServer.Models.Job> Job { get; set; }
        public DbSet<BrahmaServer.Models.Shift> Shift { get; set; }
    }
}