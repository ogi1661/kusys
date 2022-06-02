using System;
using System.Collections.Generic;
using System.Text;

namespace KUSYS.Core.Models
{
  public  class User:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
