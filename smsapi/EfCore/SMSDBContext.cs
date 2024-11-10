using Microsoft.EntityFrameworkCore;
using smsapi.Model;

namespace smsapi.EfCore
{
    public class SMSDBContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=vsdatabase;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
