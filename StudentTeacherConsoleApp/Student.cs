using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherConsoleApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double Mark { get; set; }
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; } // Navigation property
    }
}
