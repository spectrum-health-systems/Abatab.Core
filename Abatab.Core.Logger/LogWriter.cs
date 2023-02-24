using System.IO;
using System.Threading;

namespace Abatab.Core.Logger
{
    internal class LogWriter
    {
        public static void LocalFile(string logPath, string logContent, int loggingDelay = 0)
        {
            Thread.Sleep(loggingDelay);

            File.WriteAllText(logPath, logContent);
        }
    }
}
