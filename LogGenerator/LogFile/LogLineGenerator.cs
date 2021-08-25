using System;
using System.Collections.Generic;

namespace LogGenerator.LogFile
{
    public class LogLineGenerator
    {
        private DateTime StartDate;
        List<string> MessageTypes = new List<string>(4)
            {"I","D","W","E"};
        List<string> Subsystems = new List<string>()
        {
            "Subsystem",
            "AnotherSys",
            "AnalyticSystem",
            "DeclaredSys",
            "SomeSys",
            "RandomSys",
            "LogSys",
            "LoadSys"
        };

        private readonly Random Randomzier;
       
        public LogLineGenerator(DateTime startDate)
        {
            StartDate = startDate;
            Randomzier = new Random(DateTime.Now.Millisecond);
        }

        public string GenerateLogLine(int shift)
        {
            var result = string.Empty;

            var time = StartDate.AddMilliseconds(shift).ToString("dd.MM.yyyy HH:mm:ss.fff");
            var messageType = MessageTypes[Randomzier.Next(0, 3)];
            var subsystem = Subsystems[Randomzier.Next(0, Subsystems.Count - 1)];
            var message =
                MessageExamples.LogMessageExample[Randomzier.Next(0, MessageExamples.LogMessageExample.Count - 1)];

            result = $"{time} {messageType} {subsystem} {message}";
            //Console.WriteLine(result);
            return result;
        }
    }
}