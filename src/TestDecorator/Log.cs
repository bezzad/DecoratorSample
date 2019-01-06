using System;

namespace TestDecorator
{
    public class Log : ILog
    {
        public void Info(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Error(string msg)
        {
            Console.Error.WriteLine(msg);
        }

        public void Error(string msg, Exception exp)
        {
            Console.Error.WriteLine(msg, exp);
        }
    }
}