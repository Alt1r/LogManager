using System;
using System.IO;
using System.Threading.Tasks;

namespace LogGenerator.LogFile
{
    public class LogFileGenerator
    {
        public async Task CreateLogFile(int lineCount)
        {
            //TODO write correct path
            // Set a variable to the Documents path.
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(docPath,"output", $"LogFile-{DateTime.Now.ToString("yy-MM-dd-hh-mm-ss")}.txt");
            //var path = @"H:\Projects\CSharp\output";
            try
            {
                if (!File.Exists(path))
                {
                    await File.Create(path).DisposeAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //TODO add logger
                throw;
            }
            
            
            var startDate = DateTime.Now;
            var lineGenerator = new LogLineGenerator(startDate);
            await using var outputFile = new StreamWriter(path);
            try
            {
                for (var i = lineCount; i > 0; i--)
                {
                    await outputFile.WriteLineAsync(lineGenerator.GenerateLogLine(i));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}