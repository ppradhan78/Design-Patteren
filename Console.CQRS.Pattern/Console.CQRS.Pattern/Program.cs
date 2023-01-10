using Console.CQRS.Pattern.BusinessObject.Commands;
using Console.CQRS.Pattern.BusinessObject.Queries;
using Console.CQRS.Pattern.Models;
using Console.CQRS.Pattern.Repositories.Commands;
using Console.CQRS.Pattern.Repositories.Queries;
using System;
 

namespace Console.CQRS.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Command the Employee Domain to save data  
            var employeeCommand = new EmployeeCommands(new EmployeeCommandsRepository());
            employeeCommand.SaveEmployeeData(new Employee
            {
                Id = 200,
                FirstName = "Jane",
                LastName = "Smith",
                Street = "150 Toronto Street",
                City = "Toronto",
                PostalCode = "j1j1j1",
                DateOfBirth = new DateTime(2002, 2, 2)
            });
            System.Console.WriteLine("Employee data stored");


            // Query the Employee Domain to get data  
            var employeeQuery = new EmployeeQueries(new EmployeeQueriesRepository());
            var employee = employeeQuery.FindByID(100);
            System.Console.WriteLine($"Employee ID:{employee.Id}, Name:{employee.FullName}, Address:{employee.Address}, Age:{employee.Age}");
           
            System.Console.ReadKey();
        }
    }
}
