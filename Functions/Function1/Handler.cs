using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using ClassLibrary;

namespace Functions.Function1
{
    public class Handler 
    {
        public static void Run(TimerInfo timerInfo, TraceWriter log)
        {
            log.Info(Class1.GetMessage());
        }
    }
}