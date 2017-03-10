using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using WebJobber.Services;

namespace WebJobber.WebJob
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        /*public static void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log)
        {
            log.WriteLine(message);
        }*/

        public static void TimerJob([TimerTrigger("00:00:30")] TimerInfo timer)
        {
            new FileService().Write();
            //Console.Write("I ran");
        }
    }
}
