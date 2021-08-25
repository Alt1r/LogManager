using System.Collections.Generic;

namespace LogReader.FileReader.Interfaces
{
    public interface ILogReader
    {
        List<string> ReadFrom(string path);
    }
}