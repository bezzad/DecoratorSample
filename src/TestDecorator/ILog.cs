using System;

namespace TestDecorator
{
    public interface ILog
    {
        void Info(string msg);
        void Error(string msg);
        void Error(string msg, Exception exp);
    }
}