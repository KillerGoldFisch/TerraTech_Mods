using GCore.Logging;
using LoggingHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GCore.Logging.Logger
{
    public class UnityLogger : ILoggingHandler
    {
        LoggingView _lv;

        public UnityLogger(LoggingView loggingView)
        {
            _lv = loggingView;
        }

        public void Debug(DateTime timestamp, string Message, StackTrace Stacktrace, params object[] list)
        {
        }

        public void Error(DateTime timestamp, string Message, StackTrace Stacktrace, params object[] list)
        {
        }

        public void Exaption(DateTime timestamp, string Message, Exception exception, StackTrace Stacktrace, params object[] list)
        {
        }

        public void Fatal(DateTime timestamp, string Message, StackTrace Stacktrace, params object[] list)
        {
        }

        public void General(LogEntry logEntry)
        {
            var sb = new StringBuilder();

            sb.Append("[");
            sb.Append(logEntry.LogType.ToString().Substring(0, 1));
            sb.Append("] ");
            sb.Append(logEntry.Message);

            _lv.Append(sb.ToString());
        }

        public void Info(DateTime timestamp, string Message, StackTrace Stacktrace, params object[] list)
        {
        }

        public void Success(DateTime timestamp, string Message, StackTrace Stacktrace, params object[] list)
        {
        }

        public void Warn(DateTime timestamp, string Message, StackTrace Stacktrace, params object[] list)
        {
        }
    }
}
