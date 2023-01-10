using Console.CQRS.Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.CQRS.Pattern.Repositories.Queries
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }
}
