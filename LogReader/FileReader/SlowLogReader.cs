using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LogReader.FileReader.Interfaces;

namespace LogReader.FileReader
{
    public class SlowLogReader : ILogReader
    {
        //TODO Create line Filter
        DateTime startDate = new DateTime(2021, 8, 20, 19, 50, 0, 0);
        DateTime endDate = new DateTime(2021, 8, 30, 19, 50, 0, 0);

        public List<string> ReadFrom(string path)
        {
            File.ReadLines(path);
            return new List<string>();
        }

    }
}