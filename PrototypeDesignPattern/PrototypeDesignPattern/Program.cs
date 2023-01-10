using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.EmployeeId = 100;
            obj.Salary = 7000;
            obj.Adress = "Hyd";
            obj.DeptId = 10;
            obj.FullName = "Scott";
            obj.DateOfBirth = "12/12/2000";
            
            Employee obj1 = obj.EmployeeClone();
            
            obj1.Salary = 10000;
            obj1.EmployeeId = 101;

            Employee.MyProperty = 1;

            Console.WriteLine(obj1.EmployeeId);
            Console.WriteLine(obj1.Salary);
            Console.WriteLine(obj.EmployeeId);
            Console.WriteLine(obj.Salary);
            Console.WriteLine(Employee.MyProperty);

            Console.WriteLine("+++++++++++++++++++++++++++=");
            //=============================
            Dept dep = new Dept();
            dep.DeptId = 10;
            dep.Name = "IT";

            Dept dep1 = dep;
            dep1.Adress = "Hyd";


            Console.WriteLine(dep.DeptId);
            Console.WriteLine(dep.Name);

            Console.WriteLine(dep1.DeptId);
            Console.WriteLine(dep1.Adress);
            Console.ReadKey();

        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public int Salary { get; set; }
        public string Adress { get; set; }
        public int DeptId { get; set; }
        public static int MyProperty { get; set; }

        public Employee EmployeeClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

    public class Dept: ICloneable
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int DeptId { get; set; }

       

        public virtual object Clone()
        {
            return this.Clone();
        }

    }
}
