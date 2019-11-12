using FriendsList.Domain.Entities;
using FriendsList.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace FriendsList.Domain.Repositories
{
    public class FriendsRepository : IRepository<Friend>
    {
        public FriendsRepository()
        {
            // TODO: Add context reference
        }

        public IEnumerable<Friend> GetAll()
        {
            throw new NotImplementedException();
        }

        public Friend GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
