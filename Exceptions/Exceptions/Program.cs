using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NivelUno.Uno();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: { ex.Message } ");
                Console.WriteLine($"StackTrace: { ex.StackTrace } ");
                Console.WriteLine($"InnerException: { ex.InnerException } ");

                WriteEventLog(ex.Message);
            }

            Console.ReadKey();
        }



        private static void WriteEventLog(string message) 
        {
            string windowsLogType = "Application";
            string eventSource = "AppExampleException";
            if (!EventLog.SourceExists(eventSource))
            {
                EventLog.CreateEventSource(eventSource, windowsLogType);
            }

            EventLog appLog = new EventLog(windowsLogType);
            appLog.Source = eventSource;
            appLog.WriteEntry(string.Concat("Ocurrio un error grave: ", message), EventLogEntryType.Error);
        }
    }
}
