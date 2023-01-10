using FactoryDesign_Pattern.Factory;
using FactoryDesign_Pattern.SampleModel;
using FactoryDesignPattern.Example1.Factory;
using FactoryDesignPattern.Example1.Interface;
using FactoryDesignPattern.Factory.FactoryMethod;
using FactoryDesignPattern.Generic.Entity;
using FactoryDesignPattern.Generic.Factory;
using FactoryDesignPattern.Interface;
using System;

namespace FactoryPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("ContractEmployee=2, PermanentEmployee =1" );
            var employee = new Employee();
            employee.EmployeeTypeID = Convert.ToInt32(Console.ReadLine());
            BaseEmployeeFactory empFactory = new EmployeeManagerFactory().CreateFactory(employee);
   
            if (employee.EmployeeTypeID==1)
            {
                Console.WriteLine("Permanent Employee");
                Console.WriteLine("=================");
            }
            if (employee.EmployeeTypeID == 2)
            {
                Console.WriteLine("Contract Employee");
                Console.WriteLine("=================");
            }
            var emp = empFactory.ApplySalary();
            Console.WriteLine("Bonus -" + emp.Bonus+ ",HouseAllowance-" + emp.HouseAllowance+ ",HourlyPay-" + ","+emp.HourlyPay  + ", MedicalAllowance-" + emp.MedicalAllowance);
            Console.WriteLine("********************************");
            
            */
            /*
            ICarSupplier objCarSupplier = CarFactory.GetCarInstance(1);
            objCarSupplier.GetCarModel();
            Console.WriteLine("And Coloar is " + objCarSupplier.CarColor);
            */

            var factoryA = FactoryManager.GetFactoryFor<AlphaClass>();
            var alphaObject = factoryA.Create(); // object is now strong typed
            Console.WriteLine("Description: " + alphaObject.Description);

            var factoryB = FactoryManager.GetFactoryFor<BravoClass>();
            var bravoObject = factoryB.Create();
            Console.WriteLine("Name: " + bravoObject.Name);

            Console.ReadLine();
        }
    }
}
