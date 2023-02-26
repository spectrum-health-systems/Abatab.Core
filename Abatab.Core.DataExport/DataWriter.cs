// Abatab.Core.DataExport.DataWriter.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

// TODO - Move to utilities?

using System.IO;

namespace Abatab.Core.DataExport
{
    public static class DataWriter
    {
        public static void LocalFile(string logPath, string logContent)
        {
            File.WriteAllText(logPath, logContent);
        }
    }
}
