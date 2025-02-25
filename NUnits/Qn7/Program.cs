using System;
using System.Threading;
namespace PerformanceTesting
{
    public class TaskManager
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000);
            return "Task Completed";
        }
    }
}