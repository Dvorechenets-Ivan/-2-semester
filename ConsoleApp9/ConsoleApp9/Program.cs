using System;
using System.Timers;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        delegate void TimerDelegate();
        
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            int intervalInSeconds = 5;

            timer.Interval = intervalInSeconds * 1000;
            TimerDelegate timerDelegate = new TimerDelegate(MethodToExecute);
            timerDelegate += AnotherMethodToExecute;
            timer.Elapsed += (sender, e) =>timerDelegate.Invoke();
            
            timer.Start();
           
            Console.WriteLine();

            Console.ReadKey();
            timer.Stop();
        }
        static void MethodToExecute()
        {
            Console.WriteLine(""+DateTime.Now);
        }
        static void AnotherMethodToExecute()
        {
            Console.WriteLine("AnotherMethodToExecute" + DateTime.Now);
        }


    }

}
