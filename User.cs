using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysApp
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string Login { get; set; } = null!;
       
        [Required]
        [MaxLength(100)]
        public string Password { get; set; } = null!;
      
        public bool Role {  get; set; }


    }
}
