using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCVForms.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CourseModel courseModel { get; set; }
    }
}