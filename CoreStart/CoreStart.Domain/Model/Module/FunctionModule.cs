using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreStart.Domain.Model.Module
{
    public class FunctionModule : BaseModel
    {
        [MaxLength(32),Required]
        public string Name { get; set; }

        [MaxLength(64), Required]
        public string Url { get; set; }
    }
}
