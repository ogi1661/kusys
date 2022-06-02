using System;
using System.Collections.Generic;
using System.Text;

namespace KUSYS.Core.Models
{
  public  class StudentCourse : BaseModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Students Students { get; set; }

    }
}
