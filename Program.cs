using System;

namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Force database creation if missing
                context.Database.CreateIfNotExists();

                var student = new Student()
                {
                    Name = "Farzana",
                    Age = 38
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.ReadLine();
        }
    }
}
