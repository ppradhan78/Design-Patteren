using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.FactoryMethod
{
    public class TeslaVehicle : Car
    {
        protected override IVehicle ManufactureVehicle(string VehicleType)
        {
            if (VehicleType=="Care")
            {
                return new TeslaCar();
            }
            if (VehicleType == "Bike")
            {
                return new TeslaBike();
            }

            return null;
        }
    }
}
