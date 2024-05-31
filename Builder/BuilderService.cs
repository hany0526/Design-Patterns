using System;

namespace DesignPatterns.Builder
{
    public class BuilderService
    {
        public BuilderService()
        {
        }

        static void WriteColoredLine(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }

        public static void runBuilder() 
        {
            // using string Builder, 
            // StringBuilder sb = new StringBuilder();
            // sb.Append("Word 1,");
            // sb.Append("Word 2 ");
            // WriteColoredLine(sb.ToString(), ConsoleColor.Cyan);

            WriteColoredLine("***Builder Pattern***", ConsoleColor.Yellow);
                
            Director director = new Director();

            // 1, Making Car
            IProductBuilder carBuilder = ProductFactory.getInstance(1, "Jeep");
            director.constructProduct(carBuilder);
            Product car = carBuilder.GetVehicle();
             WriteColoredLine($"Car {car.Show()}");

            // 2, Making Motor Cycle
            IProductBuilder motorCycleBuilder = ProductFactory.getInstance(2, "Honda");
            director.constructProduct(motorCycleBuilder);
            Product motorCycle = carBuilder.GetVehicle();
            WriteColoredLine($"MotorCycle {motorCycle.Show()}");

            // 3, Making Small Vehicle
            IProductBuilder smallVehicleBuilder = ProductFactory.getInstance(3, "Mine cooper");
            director.constructProduct(smallVehicleBuilder);
            WriteColoredLine($"smallVehicle { smallVehicleBuilder }");

        }
    }
}
