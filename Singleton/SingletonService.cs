using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class SingletonService
    {

        public SingletonService() { }

        public static void runMain()
        {

            Task task1 = Task.Factory.StartNew(() =>
            {
                Counter counterA = Counter.GetHanyInstance();
                counterA.AddOne();
                Console.WriteLine("counter A : " + counterA.count.ToString());
            });

            Thread.Sleep(100);

            Task task2 = Task.Factory.StartNew(() =>
            {
                Counter counterB = Counter.GetHanyInstance();
                counterB.AddOne();
                Console.WriteLine("counter B : " + counterB.count.ToString());
                Console.WriteLine();
            });

        }
    }
}
