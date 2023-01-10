using FactoryDesign_Pattern.SampleModel;
using FactoryDesignPattern.Class;
using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }

}
