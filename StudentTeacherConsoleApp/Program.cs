//Console.WriteLine("Hello, OS");


using Microsoft.EntityFrameworkCore;
using StudentTeacherConsoleApp;

namespace StudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                // Show all tables information
                var students = context.Students.ToList();
                var teachers = context.Teachers.ToList();

                Console.WriteLine("Students:");
                foreach (var student in students)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Department: {student.Department}, Mark: {student.Mark}, TeacherId: {student.TeacherId}");
                }

                Console.WriteLine("\nTeachers:");
                foreach (var teacher in teachers)
                {
                    Console.WriteLine($"Id: {teacher.Id}, Name: {teacher.Name}, Age: {teacher.Age}, Department: {teacher.Department}, Salary: {teacher.Salary}");
                }
            }




            //update a student's reference teacher
            /*
            using (var context = new ApplicationDbContext())
            {
                // Retrieve the student you want to update
                var studentToUpdate = context.Students.SingleOrDefault(s => s.Name == "Alice Johnson");

                if (studentToUpdate != null)
                {
                    // Retrieve the new teacher you want to associate with the student
                    var newTeacher = context.Teachers.SingleOrDefault(t => t.Name == "Jane Smith");

                    if (newTeacher != null)
                    {
                        // Update the associated teacher reference
                        studentToUpdate.TeacherId = newTeacher.Id;

                        // Save the changes to the database
                        context.SaveChanges();

                        Console.WriteLine("Student's associated teacher updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("New teacher not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            */



            //delete teacher
            /*
            using (var context = new ApplicationDbContext())
            {
                // Retrieve the teacher you want to delete
                var teacherToDelete = context.Teachers.Include(t => t.Students).SingleOrDefault(t => t.Name == "John Doe");

                if (teacherToDelete != null)
                {
                    // Remove the associated students (optional, depending on your requirements)
                    context.Students.RemoveRange(teacherToDelete.Students);

                    // Remove the teacher from the Teachers table
                    context.Teachers.Remove(teacherToDelete);

                    // Save the changes to the database
                    context.SaveChanges();

                    Console.WriteLine("Teacher deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Teacher not found.");
                }
            }
            */



            //delete student row
            /*
            using (var context = new ApplicationDbContext())
            {
                // Retrieve the student you want to delete
                var studentToDelete = context.Students.SingleOrDefault(s => s.Name == "Alice Johnson");

                if (studentToDelete != null)
                {
                    // Remove the student from the associated teacher's students collection
                    var teacher = context.Teachers.Include(t => t.Students).SingleOrDefault(t => t.Id == studentToDelete.TeacherId);

                    if (teacher != null)
                    {
                        teacher.Students.Remove(studentToDelete);
                    }

                    // Remove the student from the Students table
                    context.Students.Remove(studentToDelete);

                    // Save the changes to the database
                    context.SaveChanges();

                    Console.WriteLine("Student deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            */



            //update data
            /*
            using (var context = new ApplicationDbContext())
            {
                // Retrieve the student you want to update
                var studentToUpdate = context.Students.SingleOrDefault(s => s.Name == "Alice Johnson");

                if (studentToUpdate != null)
                {
                    // Update the properties
                    studentToUpdate.Age = 21;
                    studentToUpdate.Mark = 92.0;

                    // Save the changes to the database
                    context.SaveChanges();

                    Console.WriteLine("Student information updated successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            /*






            //insert data
            /*
            
            using (var context = new ApplicationDbContext())
            {
                // Adding dummy teachers
                var teacher1 = new Teacher { Name = "John Doe", Age = 35, Department = "Math", Salary = 50000.00 };
                var teacher2 = new Teacher { Name = "Jane Smith", Age = 40, Department = "History", Salary = 55000.00 };

                context.Teachers.AddRange(teacher1, teacher2);
                context.SaveChanges();

                // Adding dummy students
                var student1 = new Student { Name = "Alice Johnson", Age = 20, Department = "Computer Science", Mark = 90.5, TeacherId = teacher1.Id };
                var student2 = new Student { Name = "Bob Williams", Age = 21, Department = "Physics", Mark = 88.0, TeacherId = teacher1.Id };
                var student3 = new Student { Name = "Charlie Brown", Age = 22, Department = "History", Mark = 78.5, TeacherId = teacher2.Id };
                var student4 = new Student { Name = "Diana White", Age = 23, Department = "Math", Mark = 95.2, TeacherId = teacher2.Id };

                context.Students.AddRange(student1, student2, student3, student4);
                context.SaveChanges();

                Console.WriteLine("Dummy data added successfully.");
            }

            */
        }
    }
}
