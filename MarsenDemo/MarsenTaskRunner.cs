using System;
using System.Collections.Generic;
using ParallelProcessPractice.Core;

namespace MarsenDemo
{
    public class MarsenTaskRunner : TaskRunnerBase
    {
        public override void Run(IEnumerable<MyTask> tasks)
        {
            foreach (var task in tasks)
            {
                task.DoStepN(1);
                task.DoStepN(2);
                task.DoStepN(3);
            }
        }
    }
}