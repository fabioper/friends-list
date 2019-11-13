using FriendsList.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FriendsList.Data.Contexts
{
    public class FriendsListDbContext : DbContext
    {
        public FriendsListDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Friend> Friends { get; set; }
    }
}
