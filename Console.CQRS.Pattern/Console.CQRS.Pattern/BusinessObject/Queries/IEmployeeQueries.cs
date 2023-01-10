using Console.CQRS.Pattern.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.CQRS.Pattern.BusinessObject.Queries
{
    public interface IEmployeeQueries
    {
        EmployeeDTO FindByID(int employeeID);
    }
}
