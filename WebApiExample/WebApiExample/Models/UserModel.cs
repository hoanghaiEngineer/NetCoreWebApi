using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Mobile { get; set; }
        public int Gender { get; set; }
        public string ZipCode { get; set; }
        public int Country { get; set; }
        public int Language { get; set; }
    }
}
