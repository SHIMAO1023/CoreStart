using CoreStart.Domain.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreStart.Domain.Model
{
    public class User : BaseModel
    {
        [MaxLength(16), Required]
        public string Name { get; set; }

        [MaxLength(32), Required]
        public string Email { get; set; }

        [MaxLength(16), Required]
        public string UserName { get; set; }

        [MaxLength(16), Required]
        public string Password { get; set; }

        public Gender Gender { get; set; }
    }
}
