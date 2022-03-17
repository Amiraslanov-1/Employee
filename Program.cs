using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Emil",
                Surname = "Mahmudov",
                Salary = 230,
            };

            Employee employee1 = new Employee()
            {
                Name = "Kamal",
                Surname = "Abishli",
                Salary = 150,
            };
            Employee employee2 = new Employee()
            {
                Name = "Vuqar",
                Surname = "Muradov",
                Salary = 150,
            };
            Employee employee3 = new Employee()
            {
                Name = "Vuqar",
                Surname = "Muradov",
                Salary = 150,
            };
            Employee employee4 = new Employee()
            {
                Name = "Vuqar",
                Surname = "Muradov",
                Salary = 250,
            };

            Department department = new Department()
            {
                Name = "AzerIstilik",
                SalaryLimit = 400,
                EmployeLimit = 3

            };
            try
            {
                department.AddEmployeToArr(employee);
                department.AddEmployeToArr(employee1);
                department.AddEmployeToArr(employee2);
                department.AddEmployeToArr(employee3);
                department.AddEmployeToArr(employee4);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var student in department.employees)
            {
                Console.WriteLine($"Name :{student.Name} --- Surname {student.Surname} --- Avgpoint {student.Salary}");
            }


        }
    }
}

    

