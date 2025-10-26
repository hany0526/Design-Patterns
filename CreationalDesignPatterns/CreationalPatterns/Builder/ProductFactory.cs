using CreationalDesignPatterns.CreationalPatterns.Builder.Models;

namespace CreationalDesignPatterns.CreationalPatterns.Builder
{
    public class ProductFactory
    {
        private static Product carInstance = null;
        private static Product motorInstance = null;
        private static Product smallVehicleInstance = null;

        public ProductFactory() { }

        public static Product getInstance(int p, string name = "")
        {
            switch (p)
            {
                case 1: return new Car(name);
                case 2: return new MotorCycle(name);
                case 3: return new SmallVehicle(name);
                default: return null;
            }
        }

        public static IProductBuilder getInstance(string p, string name = "")
        {
            switch (p)
            {
                case "Car": return new Car(name);
                case "Motor": return new MotorCycle(name);
                case "SmallVehicle": return new SmallVehicle(name);
                default : return null;
            }
        }

        public static Product getSingeltonInstance(int p, string name = "")
        {
            switch (p)
            {
                case 1: return carInstance ??= new Car(name);
                case 2: return motorInstance ??= new MotorCycle(name);
                case 3: return smallVehicleInstance ??= new SmallVehicle(name);
                default: return null;
            }
        }

    }
}
