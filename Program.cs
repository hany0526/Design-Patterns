using DesignPatterns.Builder;
using DesignPatterns.Prototype;
using System;

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

            // SingletonService.runMain();

            #endregion

            #region prototype


                // PrototypeService.runDeepCopy(); // Done
                // PrototypeService.runShallowCopy(); // not change same reference 

            #endregion

            #region Builder

                BuilderService.runBuilder();

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

