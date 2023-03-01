// Abatab.Core.DataExport.DataWriter.cs
// b---------x
// Copyright (c) A Pretty Cool Program

// TODO - Move to utilities?

using System.IO;

namespace Abatab.Core.DataExport
{
    /// <summary>Summary goes here.</summary>
    public static class DataWriter
    {
        /// <summary>Summary goes here.</summary>
        public static void LocalFile(string logPath, string logContent)
        {
            File.WriteAllText(logPath, logContent);
        }
    }
}
