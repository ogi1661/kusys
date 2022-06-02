using System;
using System.Collections.Generic;
using System.Text;

namespace KUSYS.Core.Models
{
   public class Students:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }

         public DateTime BrithDay { get; set; }

    }
}
