using System;
using System.Threading.Tasks;
using LogGenerator.LogFile;

namespace LogGenerator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int readed;
            var count = int.TryParse(Console.ReadLine(), out readed) ? readed : 100;
            var generator = new LogFileGenerator();
            await generator.CreateLogFile(count);
            Console.WriteLine("CreationEnded");
            Console.ReadKey();
        }
    }
}