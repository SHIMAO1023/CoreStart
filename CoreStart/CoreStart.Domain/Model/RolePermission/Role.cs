﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreStart.Domain.Model.RolePermission
{
    public class Role : BaseEntity
    {
        [MaxLength(16), Required]
        public string Name { get; set; }
    }
}
