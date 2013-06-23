using System;
using System.Collections.Generic;
using System.Text;


namespace SharpHooks.Interface
{
    public interface ILogger
    {
        void Log(LogLevel level, string message);

        void Debug(string message);

        void Info(string message);

        void Warn(string message);

        void Error(string message);
    }

    public enum LogLevel
    {
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4
    }
}
