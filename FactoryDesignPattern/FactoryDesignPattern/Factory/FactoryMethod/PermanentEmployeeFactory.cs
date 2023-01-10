using FactoryDesign_Pattern.SampleModel;
using FactoryDesignPattern.Class;
using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}
