using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Abatab.Core.Catalog
{
    public class SessionDetails
    {
        public static string test(SessionProperties sessionProperties)
        {
            if (sessionProperties.DebugglerMode == "enabled")
            {
                LocalDebuggler($@"{sessionProperties.DebugglerLogDirectory}", Assembly.GetExecutingAssembly().GetName().Name, 10);
            }

            return "";
        }

        public static string SessionDetailHeader(SessionProperties sessionProperties)
        {
            if (sessionProperties.DebugglerMode == "enabled")
            {
                LocalDebuggler($@"{sessionProperties.DebugglerLogDirectory}", Assembly.GetExecutingAssembly().GetName().Name, 10);
            }

            return Environment.NewLine +
                   $"==============={Environment.NewLine}" +
                   $"Session details{Environment.NewLine}" +
                   "================";
        }

        public static string SessionDetailBody(SessionProperties sessionProperties)
        {
            if (sessionProperties.DebugglerMode == "enabled")
            {
                LocalDebuggler($@"{sessionProperties.DebugglerLogDirectory}", Assembly.GetExecutingAssembly().GetName().Name, 10);
            }

            return Environment.NewLine +
                   $"Abatab version:               v23.2.0-development+230224.1346{Environment.NewLine}" +
                   $"Abatab mode:                  {sessionProperties.AbatabMode}{Environment.NewLine}" +
                   $"Abatab service root:          {sessionProperties.AbatabServiceRoot}{Environment.NewLine}" +
                   $"Abatab data root:             {sessionProperties.AbatabDataRoot}{Environment.NewLine}" +
                   $"Logging mode:                 {sessionProperties.LoggerMode}{Environment.NewLine}" +
                   $"Logging delay:                {sessionProperties.LoggerDelay}{Environment.NewLine}" +
                   $"Abatab fallback username:     {sessionProperties.AbatabFallbackUserName}{Environment.NewLine}" +
                   $"Debuggler mode:               {sessionProperties.DebugglerMode}{Environment.NewLine}" +
                   $"Session datestamp:            {sessionProperties.Datestamp}{Environment.NewLine}" +
                   $"Session timestamp:            {sessionProperties.Timestamp}{Environment.NewLine}" +
                   $"Script parameter:             {sessionProperties.ScriptParameter}{Environment.NewLine}" +
                   $"Request module:               {sessionProperties.RequestModule}{Environment.NewLine}" +
                   $"Request command:              {sessionProperties.RequestCommand}{Environment.NewLine}" +
                   $"Request action:               {sessionProperties.RequestAction}{Environment.NewLine}" +
                   $"Request option:               {sessionProperties.RequestOption}{Environment.NewLine}" +
                   $"Abatab username:              {sessionProperties.AbatabUserName}{Environment.NewLine}" +
                   $"Session data root:            {sessionProperties.SessionDataRoot}{Environment.NewLine}" +
                   $"Warning log directory:        {sessionProperties.WarningLogDirectory}{Environment.NewLine}" +
                   $"Public data root:             {sessionProperties.PublicDataRoot}{Environment.NewLine}" +
                   $"Public warning log directory: {sessionProperties.PublicWarningLogDirectory}{Environment.NewLine}" +
                   $"Debuggler log directory:      {sessionProperties.DebugglerLogDirectory}{Environment.NewLine}" +
                   Environment.NewLine;
            //$"============================{Environment.NewLine}" +
            //$"Module details{Environment.NewLine}" +
            //$"============================" +
            //$"{BodyModuleDetail(abatabSession, "Date")}{Environment.NewLine}" +
            //$"{BodyModuleDetail(abatabSession, "QuickMedOrder")}{Environment.NewLine}" +
            //$"{BodyModuleDetail(abatabSession, "Prototype")}{Environment.NewLine}" +
            //$"{BodyModuleDetail(abatabSession, "Testing")}{Environment.NewLine}" +
            //Environment.NewLine +
            //$"===================={Environment.NewLine}" +
            //$"OptionObject details{Environment.NewLine}" +
            //$"====================" +
            //$"{BodyOptObjDetail(abatabSession.SentOptObj, "sentOptObj")}{Environment.NewLine}" +
            //$"{BodyOptObjDetail(abatabSession.WorkOptObj, "workerOptObj")}{Environment.NewLine}" +
            //$"{BodyOptObjDetail(abatabSession.FinalOptObj, "finalOptObj")}{Environment.NewLine}";
        }

        public static void LocalDebuggler(string logDirectory, string exeAssembly, int loggerDelay, [CallerFilePath] string callPath = "", [CallerMemberName] string callMember = "", [CallerLineNumber] int callLine = 0)
        {
            Thread.Sleep(loggerDelay);
            File.WriteAllText($@"{logDirectory}\{exeAssembly}-{Path.GetFileName(callPath)}-{callMember}-{callLine}.debuggler", "");
        }
    }
}
