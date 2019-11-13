using FriendsList.Domain.Entities;
using System.Collections.Generic;

namespace FriendsList.Domain.Interfaces
{
    public interface IRepository<T> where T: Entity
    {
        IEnumerable<T> GetAll();
        T GetById(long id);
    }
}
