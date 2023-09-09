using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Problems
{
    class LoggerRateLimiter
    {

        private const int TIMEOUT = 10;
        private static Dictionary<string, int> _inputMessagesWithExpiryTimes = new Dictionary<string, int>();

        public static void Solution()
        {
            Tuple<string, int>[] input = new Tuple<string, int>[] {
                    new Tuple<string, int>("foo", 1),
                    new Tuple<string, int>("bar", 2),
                    new Tuple<string, int>("foo", 3),
                    new Tuple<string, int>("bar", 8),
                    new Tuple<string, int>("foo", 10),
                    new Tuple<string, int>("foo", 11),
            };

            Console.WriteLine("[");
            foreach (Tuple<string, int> msg in input)
            {
                Console.Write(ShouldPrintMessage(msg.Item2, msg.Item1) + ", ");
            }
            Console.WriteLine("]");
        }

        public static bool ShouldPrintMessage(int timestamp, string message)
        {
            if (!_inputMessagesWithExpiryTimes.ContainsKey(message))
            {
                _inputMessagesWithExpiryTimes.Add(message, timestamp);
                return true;
            }
            var oldTimestamp = _inputMessagesWithExpiryTimes[message];
            if (timestamp - oldTimestamp >= TIMEOUT)
            {
                _inputMessagesWithExpiryTimes[message] = timestamp;
                return true;
            }
            else
            {
                return false;
            }
        }


        /* ======= Complexity explained

        */
    }
}