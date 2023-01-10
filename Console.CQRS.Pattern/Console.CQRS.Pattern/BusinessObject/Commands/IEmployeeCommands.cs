using Console.CQRS.Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.CQRS.Pattern.BusinessObject.Commands
{
    public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }
}
