using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.FactoryMethod
{
    public abstract class Car
    {

        public IVehicle ProduceVehicle(string VehicleType)
        {
            IVehicle vehicle= ManufactureVehicle(VehicleType);
            vehicle.Manufacture();
            return vehicle;
        }

        protected abstract IVehicle ManufactureVehicle(string VehicleType);
    }
}
