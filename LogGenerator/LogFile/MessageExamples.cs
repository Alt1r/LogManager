using System.Collections.Generic;

namespace LogGenerator.LogFile
{
    public class MessageExamples
    {
        public static List<string> LogLineExample =  new List<string>(){
            @"01.01.2021 00:00:00.000 W Subsystem Message too large, ID=3889c50e-c194-4f54-9c8c-f12d9d8d2d19\1145732",
            @"07.01.2021 15:39:26.553 W AnotherSys [Обработчик 'оповещение портала'] - получено сообщение с типом 'AdapterBusMessage.Internal.ReqPortalStatusMessage', обратный адрес = 'localadapterqueuedev@192.168.1.59' at 07.01.2021 04:57:43.765"
        };
        public static List<string> LogMessageExample = new List<string>()
        {
            @"Message too large, ID=3889c50e-c194-4f54-9c8c-f12d9d8d2d19\1145732",
            @"[Обработчик 'оповещение портала'] - получено сообщение с типом 'AdapterBusMessage.Internal.ReqPortalStatusMessage', обратный адрес = 'localadapterqueuedev@192.168.1.59' at 07.01.2021 04:57:43.765"
        };
    }
}