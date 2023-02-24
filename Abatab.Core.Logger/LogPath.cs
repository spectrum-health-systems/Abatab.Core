// Abatab.Core.Logger.LogPath.cs
// b230224.1700
// Copyright (c) A Pretty Cool Program

using System;
using System.IO;

namespace Abatab.Core.Logger
{
    internal static class LogPath
    {
        public static string Build(string eventType, string sessionRoot, string exeAssembly = "", string callPath = "", string callMember = "", int callLine = 0)
        {
            switch (eventType)
            {
                case "trace":
                    return $@"{sessionRoot}\trace\{DateTime.Now:HHmmss_fffffff}-{exeAssembly}-{Path.GetFileName(callPath)}-{callMember}-{callLine}.{eventType}";

                default:
                    return $@"{sessionRoot}\lost\{DateTime.Now:HHmmss_fffffff}-{exeAssembly}-{Path.GetFileName(callPath)}-{callMember}-{callLine}.lost";
            }
        }

        public static string Build(string eventType, string sessionRoot)
        {
            switch (eventType)
            {
                case "session":
                    return $@"{sessionRoot}\{DateTime.Now:yyMMdd}.{eventType}";

                default:
                    return $@"{sessionRoot}\{DateTime.Now:yyMMdd}.lost";
            }
        }
    }
}
