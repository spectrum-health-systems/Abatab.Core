// Abatab.Core.Logger.LogWriter.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System.IO;
using System.Threading;

namespace Abatab.Core.Logger
{
    internal static class LogWriter
    {
        public static void LocalFile(string logPath, string logContent, int loggerDelay)
        {
            Thread.Sleep(loggerDelay);
            File.WriteAllText(logPath, logContent);
        }
    }
}