using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Temp.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage="NAme is required`")]
        public String Name { get; set; }
        [DataType(DataType.Password)]
        [MaxLength(16), MinLength(2)]
        public String Password { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public String Phone { get; set; }
    }
}