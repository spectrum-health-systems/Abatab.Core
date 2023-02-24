// Abatab.Core.Logger.Writer.cs
// b230224.1700
// Copyright (c) A Pretty Cool Program

using System.IO;
using System.Threading;

namespace Abatab.Core.Logger
{
    internal static class LogWriter
    {
        public static void LocalFile(string logPath, string logContent, int loggingDelay)
        {
            Thread.Sleep(loggingDelay);
            File.WriteAllText(logPath, logContent);
        }
    }
}