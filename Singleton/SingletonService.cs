using System;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class SingletonService
    {

        public SingletonService() { }
        
        public static void runMain()
        {
            Counter counter1 = Counter.GetInstance();
            Counter counter2 = Counter.GetInstance();

            Task task1 = Task.Factory.StartNew(() => {  
            Counter counter1 = Counter.GetInstance();
            counter1.AddOne();
            Console.WriteLine("counter 1 : "+ counter1.count.ToString());
         }); 

         Task task2 = Task.Factory.StartNew(() => {  
            counter2 = Counter.GetInstance();
            counter2.AddOne();
            Console.WriteLine("counter 2 : "+ counter2.count.ToString());
            Console.WriteLine();
         }); 
            
            counter1.AddOne();
            Console.WriteLine("counter 1 :"+ counter1.count.ToString());
            Console.WriteLine("counter 2 :"+ counter2.count.ToString());
        }
    }
}
