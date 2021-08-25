using System;

namespace LogReader
{
    public class StringParser
    {
        public static DateTime GetDateFromString(string line)
        {
            DateTime result;
            var str = line.Substring(0, 23);
            DateTime.TryParseExact(str, "dd.MM.yyyy HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out result);
            return result;
        }
    }
}