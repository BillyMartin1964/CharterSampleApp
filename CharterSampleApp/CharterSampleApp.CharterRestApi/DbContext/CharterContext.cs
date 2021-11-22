using CharterSampleApp.CharterRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CharterSampleApp.CharterRestApi.DbContext
{
    public class CharterContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CharterContext(DbContextOptions<CharterContext> options)
            : base(options)
        {
                
        }

        public DbSet<UserAccount> CharterUserAccount { get; set; } = null!;
        public DbSet<Address> UserAddress { get; set; } = null!;
        public DbSet<BillingStatement> UserBillingStatement { get; set; } = null!;
    }
}
