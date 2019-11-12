using FriendsList.Domain.Entities;
using System.Collections.Generic;

namespace FriendsList.Domain.Interfaces
{
    public interface IRepository<T> where T: GenericEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
