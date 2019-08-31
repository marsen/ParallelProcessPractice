using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ParallelProcessPractice.Core;

namespace MarsenDemo
{
    public class MarsenTaskRunner : TaskRunnerBase
    {
        public override void Run(IEnumerable<MyTask> tasks)
        {
            Parallel.ForEach(
                tasks,
                task =>
                {
                    task.DoStepN(1);
                    task.DoStepN(2);
                    task.DoStepN(3);
                }
            );
        }
    }
}
