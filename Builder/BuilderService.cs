using System;
using System.Text;
using DesignPatterns.Builder.Models;

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

        public static void runStringBuilder()
        {
            // using string Builder,
            StringBuilder sb = new StringBuilder();
            sb.Append("Word 1,");
            sb.Append("Word 2 ");
            WriteColoredLine(sb.ToString(), ConsoleColor.Cyan);
        }

        public static void runBuilder() 
        {
            WriteColoredLine("***Builder Pattern***", ConsoleColor.Yellow);
            // Director director = new Director();

            // 1, Making Car
            Product car = ProductFactory.getInstance(1, "Jeep");
            
            car.prepareProduct();
            // director.constructProduct(carBuilder);
            
            WriteColoredLine($"Car {car.Show()}");

            // 2, Making Motor Cycle
            Product motorCycle = ProductFactory.getInstance(2, "Honda");
            
            motorCycle.prepareProduct();
            // director.constructProduct(motorCycle);
            
            WriteColoredLine($"MotorCycle {motorCycle.Show()}");

            // 3, Making Small Vehicle
            Product smallVehicle = ProductFactory.getInstance(3, "Mine cooper");
            
            smallVehicle.prepareProduct();
            // director.constructProduct(smallVehicle);
            
            WriteColoredLine($"smallVehicle {smallVehicle}");


            // 4, big Car
            Product bigCar = ProductFactory.getInstance(1, "big Car");
            bigCar.prepareProduct();
            WriteColoredLine($"bigCar {bigCar}");


        }
    }
}
