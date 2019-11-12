using System;
using System.ComponentModel.DataAnnotations;

namespace FriendsList.Domain.Entities
{
    public class Friend : GenericEntity
    {
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        public string FamilyName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Data de aniversário")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}
