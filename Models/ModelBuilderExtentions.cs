using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAsp.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
           new Employee
           {
               Id = 2,
               Department = Dept.IT,
               Email = "neee@gmail.com",
               Name = "Mark"
           }
           );
        }
    }
}
