// Abatab.Core.Logger.LogWriter.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System.IO;
using System.Threading;

namespace Abatab.Core.Logger
{
    /// <summary>Summary goes here.</summary>
    internal static class LogWriter
    {
        /// <summary>Summary goes here.</summary>
        public static void LocalFile(string logPath, string logContent, int loggerDelay)
        {
            Thread.Sleep(loggerDelay);
            File.WriteAllText(logPath, logContent);
        }
    }
}