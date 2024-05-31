using DesignPatterns.Builder;
using DesignPatterns.Singleton;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void WriteColoredLine(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            #region Creational Patterns


            #region Singleton Pattern
            
            SingletonService.runMain();

            #endregion

            #region prototype
            /*EmployeePrototype tempEmp1 = new TempEmployee();
            tempEmp1.Name = "temp employee 1";
            tempEmp1.Id = 1;
            tempEmp1.EmpAddress = new Address{City="city 1", Building="B1", StreetName="street name"};
            EmployeePrototype tempEmp2 =tempEmp1.ShallowCopy();

            Console.WriteLine("========= Temp Emp 1 Original Values=============");
            Console.WriteLine(tempEmp1.ToString());
            Console.WriteLine("========= Temp Emp 2 Copy========================");
            Console.WriteLine(tempEmp2.ToString());

            tempEmp2.EmpAddress.City="new city";
            tempEmp2.Name="sadasdasd";
            tempEmp2.Id=1000;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========= Temp Emp 1 After Change =============");
            Console.WriteLine(tempEmp1.ToString());
            Console.WriteLine("========= Temp Emp 2 ==========================");
            Console.WriteLine(tempEmp2.ToString());*/

            #endregion

            #region Builder

            /*
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Word 1,");
            sb.Append("Word 2");

            WriteColoredLine(sb.ToString(), ConsoleColor.Cyan);
            WriteColoredLine("***Builder Pattern***", ConsoleColor.Yellow);
            Director director = new Director();
            IBuilder carBuilder = new Car("Jeep");
            IBuilder motorCycleBuilder = new MotorCycle("Honda");

            // Making Car
            director.BuildCar(carBuilder);
            Product car = carBuilder.GetVehicle();
            WriteColoredLine($"Car {car.Show()}");

            //Making MotorCycle
            director.BuildCar(motorCycleBuilder);
            Product motorCycle = motorCycleBuilder.GetVehicle();
            WriteColoredLine($"MotorCycle {motorCycle.Show()}");
            /* */

            #endregion

            #region Factory Method 

            /* 
            string cardNumber,bankCode;
            BankFactory bankFactory = new BankFactory ();

            WriteColoredLine("Enter your card number",ConsoleColor.Cyan);
            cardNumber=Console.ReadLine();
            bankCode=cardNumber.Substring(0,6);
            IBank bank = bankFactory.GetBank(bankCode);
            IPaymentCard paymentCard = bankFactory.GetPaymentCard("12");

            WriteColoredLine(bank.Withdraw());
            WriteColoredLine(paymentCard.GetName());
            */

            #endregion

            #endregion

            #region Structural Patterns

            #region Proxy
            /*StructuralPatterns.SMSServiceProxy proxy = new StructuralPatterns.SMSServiceProxy ();

            WriteColoredLine(proxy.SendSMS("123","01100000","message 1"));
            WriteColoredLine(proxy.SendSMS("123","01100000","message 1"));
            WriteColoredLine(proxy.SendSMS("123","01100000","message 1"));*/
            #endregion

            #region  Decorator 
            /*StructuralPatterns.ConcereteSMSService smsService = new StructuralPatterns.ConcereteSMSService ();
            StructuralPatterns.NotificationEmailDecorator emailDecorator = new StructuralPatterns.NotificationEmailDecorator();             
             
            emailDecorator.SetService(smsService);
            WriteColoredLine(emailDecorator.SendSMS("123","01100000","message 1"));*/

            #endregion

            #region  Adapter 
            /*Employee emp =new Employee ();
            MachineOperator machineOperator=new MachineOperator ();
            machineOperator.BasicSalary =1200;

            emp.Name ="test"; emp.BasicSalary=1000;
            SalaryAdapter calculator = new SalaryAdapter ();
            var salary= calculator.CalcSalary(machineOperator);
            WriteColoredLine(salary.ToString());*/
            #endregion

            #region Facade 

            /* ShoppingBasket basket =new ShoppingBasket ();
             basket.AddItem(new BasketItem {ItemID="123",ItemPrice=50,Quantity=3});
             basket.AddItem(new BasketItem {ItemID="456",ItemPrice=40,Quantity=2});

             PurchaseOrder order = new PurchaseOrder ();
             order.CreateOrder(basket,"name:mohammed,bank:123456789,mobile:0100000");
             */


            #endregion

            #region Flyweight
            /*
            DiscountCalcFactory discountFactory = new DiscountCalcFactory();
            var calculator = discountFactory.GetDiscountCalc("day");
            var val = calculator.GetDiscountValue(DateTime.Now.Date);
            WriteColoredLine(val.ToString());
            */
            #endregion

            #endregion  // End of structural patterns

            Console.ReadKey();
        }
    }
}

