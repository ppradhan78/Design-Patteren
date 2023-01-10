using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.FactoryMethod
{
    public class TataVehicle : Car
    {
        protected override IVehicle ManufactureVehicle(string VehicleType)
        {
            if (VehicleType=="Care")
            {
                return new TataCar();
            }
            if (VehicleType == "Bike")
            {
                return new TataBike();
            }

            return null;
        }
    }
}
