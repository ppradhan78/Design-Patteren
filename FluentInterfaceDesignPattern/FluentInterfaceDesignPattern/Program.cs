﻿using System;
using System.Text.Json;

namespace FluentInterfaceDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();
            obj.NameOfTheEmployee("Anurag Mohanty")
                    .Born("10/10/1992")
                    .WorkingOn("IT")
                    .StaysAt("Mumbai-India");

            string jsonString = JsonSerializer.Serialize(obj);
            Console.WriteLine(jsonString);
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
    }
    public class FluentEmployee
    {
        private Employee employee = new Employee();
        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            employee.FullName = FullName;
            return this;
        }
        public FluentEmployee Born(string DateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            return this;
        }
        public FluentEmployee StaysAt(string Address)
        {
            employee.Address = Address;
            return this;
        }
    }
}
