using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class ProductFactory
    {
        public static IProductBuilder getInstance(int p, string name = "")
        {
            switch (p)
            {
                case 1: return new CarBuilder(name);
                case 2: return new MotorCycleBuilder(name);
                case 3: return new SmallVehicleBuilder(name);
                default: return null;
            }
        }

        public static IProductBuilder getInstance(string p, string name = "")
        {
            switch (p)
            {
                case "Car": return new CarBuilder(name);
                case "Motor": return new MotorCycleBuilder(name);
                case "SmallVehicle": return new SmallVehicleBuilder(name);
                default : return null;
            }
        }
    }
}
