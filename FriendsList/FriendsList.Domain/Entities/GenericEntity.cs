using System.ComponentModel.DataAnnotations;

namespace FriendsList.Domain.Entities
{
    public abstract class GenericEntity
    {
        [Key, Required]
        public long Id { get; set; }
    }
}
