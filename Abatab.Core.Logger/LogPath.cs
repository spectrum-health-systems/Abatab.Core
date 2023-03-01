// Abatab.Core.Logger.LogPath.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System;
using System.IO;

namespace Abatab.Core.Logger
{
    /// <summary>Summary goes here.</summary>
    internal static class LogPath
    {
        /// <summary>Summary goes here.</summary>
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

        /// <summary>Summary goes here.</summary>
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
