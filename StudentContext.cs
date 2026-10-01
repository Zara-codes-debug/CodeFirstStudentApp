using System.Data.Entity;

namespace CodeFirstStudentApp
{
    public class StudentContext : DbContext
    {
        public StudentContext() 
            : base(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True") 
        { }

        public DbSet<Student> Students { get; set; } = null!;
    }
}
