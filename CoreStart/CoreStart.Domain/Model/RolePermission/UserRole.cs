using System;
using System.Collections.Generic;
using System.Text;

namespace CoreStart.Domain.Model.Role
{
    public class UserRole : BaseModel
    {
        public int UserID { get; set; }

        public int RoleID { get; set; }
    }
}
