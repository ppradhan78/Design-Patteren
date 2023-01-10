using Console.CQRS.Pattern.Models;
using Console.CQRS.Pattern.Repositories.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.CQRS.Pattern.BusinessObject.Commands
{
    public class EmployeeCommands : IEmployeeCommands
    {
        private readonly IEmployeeCommandsRepository _repository;
        public EmployeeCommands(IEmployeeCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveEmployeeData(Employee employee)
        {
            _repository.SaveEmployee(employee);
        }
    }
}
