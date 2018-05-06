using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace ThreadLearning1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Starting program...");
            Thread thread1 = new Thread(PrintNumbersWithDelay);
            thread1.Start();
            Thread.Sleep(TimeSpan.FromSeconds(6));
            thread1.Abort();
            WriteLine("A thread has been aborted!");
            Thread thread2 = new Thread(PrintNumbers);
            thread2.Start();
            PrintNumbers();
        }
        static void PrintNumbers()
        {
            WriteLine("Start PrintNumbers!");
            for(int i=0;i<10;i++)
            {
                WriteLine(i);
            }
        }
        static void PrintNumbersWithDelay()
        {
            WriteLine("Start PrintNumbersWithDelay!");
            for(int i=0;i<10;i++)
            {
                Sleep(TimeSpan.FromSeconds(2));
                WriteLine(i);
            }
        }
    }
}
