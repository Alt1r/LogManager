using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LogReader.Tests
{
    public class StringParserTest
    {
        [Test]
        public void GetDateFromStringTest()
        {
            //Arrange
            var testStrings = new List<string>(2)
            {
                @"01.01.2021 00:00:00.000 W Subsystem Message too large, ID=3889c50e-c194-4f54-9c8c-f12d9d8d2d19\1145732",
                @"07.01.2021 15:39:26.553 W AnotherSys [Обработчик 'оповещение портала'] - получено сообщение с типом 'AdapterBusMessage.Internal.ReqPortalStatusMessage', обратный адрес = 'localadapterqueuedev@192.168.1.59' at 07.01.2021 04:57:43.765"
            };
            var testDate = new List<DateTime>(2)
            {
                new DateTime(2021, 1, 1, 0, 0, 0, 0),
                new DateTime(2021, 1, 07, 15, 39, 26, 553),
            };
            var result = new List<bool>(2);
            //Act
            for (int i = 0; i < 2; i++)
            {
                var methodResult = StringParser.GetDateFromString(testStrings[i]);
                Console.WriteLine(methodResult.ToString());
                result.Add(methodResult == testDate[i]);
            }
            
            //Asserrt
            Assert.True(result.All(x => x == true));
        }
    }
}