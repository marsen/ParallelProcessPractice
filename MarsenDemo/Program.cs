using System;
using ParallelProcessPractice.Core;

namespace MarsenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskRunnerBase run = new MarsenTaskRunner();
            run.ExecuteTasks(100);
            Console.ReadLine();
        }
    }
}
