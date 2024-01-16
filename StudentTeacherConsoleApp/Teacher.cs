namespace StudentTeacherConsoleApp
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public List<Student> Students { get; set; } // Navigation property
    }
}