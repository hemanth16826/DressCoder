using DressCoder.Models;
using Microsoft.EntityFrameworkCore;

namespace DressCoder.DataContext
{
    public class DataContextTables :DbContext
    {
        public DataContextTables(DbContextOptions<DataContextTables> options):base(options) 
        {
        }
        public DbSet<UserLogin>UserLogins { get; set; }
        public DbSet<Companies> Companies { get; set; }
    }
}
