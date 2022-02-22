using ChushkaMiro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChushkaMiro.Models
{
    public class UsersVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This is mandatory")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This is mandatory")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "This is mandatory")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This is mandatory")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This is mandatory")]
        [EnumDataType(typeof(RolesType))]
        public RolesType Role { get; set; }
        public ICollection<Orders> Order { get; set; }

    }
}
