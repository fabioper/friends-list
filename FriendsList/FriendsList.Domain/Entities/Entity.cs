using System;
using System.ComponentModel.DataAnnotations;

namespace FriendsList.Domain.Entities
{
    public abstract class Entity
    {
        [Key, Required]
        public long Id { get; set; }

        public override bool Equals(object obj) =>
            obj is Entity entity && Id == entity.Id;

        public override int GetHashCode() => HashCode.Combine(Id);
    }
}
