using System;
using System.Collections.Generic;
using System.Text;

namespace KUSYS.Core.Models
{
    public class BaseModel
    {
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
