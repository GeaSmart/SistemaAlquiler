using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Username { get; set; }
        [Required]
        [StringLength(250)]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
