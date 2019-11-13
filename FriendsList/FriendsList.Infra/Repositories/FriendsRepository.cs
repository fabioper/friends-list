using FriendsList.Data.Contexts;
using FriendsList.Domain.Entities;
using FriendsList.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FriendsList.Domain.Repositories
{
    public class FriendsRepository : IRepository<Friend>
    {
        private readonly FriendsListDbContext _context;

        public FriendsRepository(FriendsListDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Friend> GetAll() => _context.Friends.OrderBy(f => f.Id);

        public Friend GetById(long id)
        {
            return _context.Friends.FirstOrDefault(f => f.Id == id);
        }
    }
}
