using Microsoft.EntityFrameworkCore;
using SysLogin.Models;

namespace SysLogin.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserModel> User { get; set; }


    }
}
