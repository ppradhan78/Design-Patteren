using Console.CQRS.Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.CQRS.Pattern.Repositories.Commands
{
    public interface IEmployeeCommandsRepository
    {
        void SaveEmployee(Employee employee);
    }
}
