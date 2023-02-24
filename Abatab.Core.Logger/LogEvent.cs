using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Abatab.Core.Catalog;

namespace Abatab.Core.Logger
{
    public class LogEvent
    {
        public static void Debuggler(string logDirectory, string exeAssembly, string logContent = "", [CallerFilePath] string callPath = "", [CallerMemberName] string callMember = "", [CallerLineNumber] int callLine = 0)
        {
            var logPath = $@"{logDirectory}\{DateTime.Now:HHmmss_fffffff}-{exeAssembly}-{Path.GetFileName(callPath)}-{callMember}-{callLine}.debuggler";

            LogWriter.LocalFile(logPath, logContent);
        }

        public static void Trace(SessionProperties sessionProperties, string exeAssembly, [CallerFilePath] string callPath = "", [CallerMemberName] string callMember = "", [CallerLineNumber] int callLine = 0)
        {
            if (sessionProperties.DebugglerMode == "enabled") /* For testing/debugging only */
            {
                LogEvent.Debuggler($@"C:\AbatabData\{sessionProperties.AvatarEnvironment}\debuggler\", Assembly.GetExecutingAssembly().GetName().Name);
            }

            if (sessionProperties.LoggerMode == "all" || sessionProperties.LoggerMode.Contains("trace"))
            {
                var logPath = LogPath.Build("trace", sessionProperties.SessionDataRoot, exeAssembly, callPath, callMember, callLine);

                LogWriter.LocalFile(logPath, "", Convert.ToInt32(sessionProperties.LoggerDelay));
            }
        }
    }
}