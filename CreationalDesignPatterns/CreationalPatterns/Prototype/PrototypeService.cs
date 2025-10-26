using CreationalDesignPatterns.CreationalPatterns.Prototype;
using System;

namespace CreationalDesignPatterns.CreationalPatterns.Prototype
{
    public class PrototypeService
    {
        public PrototypeService() { }

        public static void runDeepCopy()
        {
            // polymorphism
            EmployeePrototype tempEmp1 = new TempEmployee();
            tempEmp1.Id = 1;
            tempEmp1.Name = "temp employee 1";
            tempEmp1.EmpAddress = new Address { City = "city 1", Building = "B1", StreetName = "street name" };


            // 2nd tempEmp2 Obj will refer ro new refernce in the memory, only have same data in tempEmp1 
            // then tempEmp1 data will not update same data tempEmp2

            EmployeePrototype tempEmp2 = tempEmp1.DeepCopy();

            Console.WriteLine("========= Temp Emp 1 Original Values =============");
            Console.WriteLine(tempEmp1.ToString());
            Console.WriteLine("========= Temp Emp 2 Copy ========================");
            Console.WriteLine(tempEmp2.ToString());

            tempEmp2.Id = 1000;
            tempEmp2.Name = "sadasdasd";
            tempEmp2.EmpAddress.City = "new city";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========= Temp Emp 1 After Change =============");
            Console.WriteLine(tempEmp1.ToString());

            Console.WriteLine("========= Temp Emp 2 ==========================");
            Console.WriteLine(tempEmp2.ToString());
        }


        public static void runShallowCopy()
        {
            // polymorphism
            EmployeePrototype tempEmp1 = new TempEmployee();
            tempEmp1.Id = 1;
            tempEmp1.Name = "temp employee 1";
            tempEmp1.EmpAddress = new Address { City = "city 1", Building = "B1", StreetName = "street name" };


            // 2nd tempEmp2 Obj will refernce to tempEmp1 Obj in the memory 
            // then tempEmp1 data will update same tempEmp2

            EmployeePrototype tempEmp2 = tempEmp1.ShallowCopy();

            Console.WriteLine("========= Temp Emp 1 Original Values =============");
            Console.WriteLine(tempEmp1.ToString());

            Console.WriteLine("========= Temp Emp 2 Copy ========================");
            Console.WriteLine(tempEmp2.ToString());

            tempEmp1.Id = 1000;
            tempEmp1.Name = "sadasdasd";
            tempEmp1.EmpAddress.City = "new city";
            
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========= Temp Emp 1 After Change =============");
            Console.WriteLine(tempEmp1.ToString());

            Console.WriteLine("========= Temp Emp 2 ==========================");
            Console.WriteLine(tempEmp2.ToString());
            
            Console.WriteLine(tempEmp1.Name);
            Console.WriteLine(tempEmp2.Name);
        }
    }
}
