// Abatab.Core.Logger.LogEvent.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System;
using System.Runtime.CompilerServices;
using Abatab.Core.Catalog;

namespace Abatab.Core.Logger
{
    public static class LogEvent
    {
        // TODO - Maybe figure out a better way to do this, instead of checking if logging is enabled and then checking to see if the types are correct.

        public static void Trace(SessionProperties sessionProperties, string exeAssembly, [CallerFilePath] string callPath = "", [CallerMemberName] string callMember = "", [CallerLineNumber] int callLine = 0)
        {
            //Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            if (sessionProperties.LoggerMode == "enabled")
            {
                if (sessionProperties.LoggerTypes == "all" || sessionProperties.LoggerTypes.Contains("trace"))
                {
                    var logPath = LogPath.Build("trace", sessionProperties.SessionDataRoot, exeAssembly, callPath, callMember, callLine);

                    LogWriter.LocalFile(logPath, "", Convert.ToInt32(sessionProperties.LoggerDelay));
                }
            }
        }

        public static void TraceMsg(SessionProperties sessionProperties, string exeAssembly, string logMsg = "Trace log", [CallerFilePath] string callPath = "", [CallerMemberName] string callMember = "", [CallerLineNumber] int callLine = 0)
        {
            //Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            if (sessionProperties.LoggerMode == "enabled")
            {
                if (sessionProperties.LoggerTypes == "all" || sessionProperties.LoggerTypes.Contains("trace"))
                {
                    var logPath = LogPath.Build("trace", sessionProperties.SessionDataRoot, exeAssembly, callPath, callMember, callLine);

                    LogWriter.LocalFile(logPath, logMsg, Convert.ToInt32(sessionProperties.LoggerDelay));
                }
            }
        }
    }
}