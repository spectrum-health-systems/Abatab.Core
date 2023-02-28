using System.Reflection;
using Abatab.Core.Catalog.Definition;
using Abatab.Core.Logger;

namespace Abatab.Core.Framework
{
    public class Refresh
    {
        public static void Daily(AbSession abSession)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            Verify.DirectoriesExist(Abatab.Core.Catalog.Component.Directories.ForFramework(abSession));
            Core.DataExport.SessionInformation.DailyRefresh(abSession, $@"{abSession.AbatabDataRoot}\{abSession.AvatarEnvironment}\Abatab current settings.md");
        }
    }
}
