using System;
using System.Collections.Generic;
using System.Text;

namespace CoreStart.Domain.Model.Module
{
    public class FunctionModuleRole : BaseEntity
    {
        public int FunctionModuleID { get; set; }

        public int RoleID { get; set; }
    }
}
