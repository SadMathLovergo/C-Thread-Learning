using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace ThreadLearning2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Starting program!");
            Thread t1 = new Thread(PrintNumbersWithStatus);
            Thread t2 = new Thread(DoNothing);
            WriteLine("thread t1 state:{0}", t1.ThreadState.ToString());
            t2.Start();
            t1.Start();
            for(int i=0;i<30;i++)
            {
                WriteLine("thread t1 state:{0}",t1.ThreadState.ToString());
            }
            Sleep(TimeSpan.FromSeconds(6));
            t1.Abort();
            WriteLine("A thread has been aborted!");
            WriteLine("thread t1 state:{0}",t1.ThreadState.ToString());
            WriteLine("thread t2 state:{0}", t2.ThreadState.ToString());
        }
        static void DoNothing()
        {
            WriteLine("Starting DoNothing!");
            Sleep(TimeSpan.FromSeconds(2));
        }
        static void PrintNumbersWithStatus()
        {
            WriteLine("Starting PrintNumbersWithStatus!");
            WriteLine(CurrentThread.ThreadState.ToString());
            for(int i=0;i<10;i++)
            {
                Sleep(TimeSpan.FromSeconds(2));
                WriteLine(i);
            }
        }
    }
}
