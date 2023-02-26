using Abatab.Core.Catalog.Definition;

namespace Abatab.Core.Framework
{
    public class Refresh
    {
        public static void Daily(AbSession abSession)
        {
            Verify.DirectoriesExist(Abatab.Core.Catalog.Component.Directories.ForFramework(abSession));
            Core.DataExport.SessionInformation.DailyRefresh(abSession, $@"{abSession.AbatabDataRoot}\{abSession.AvatarEnvironment}\Abatab current settings.md");
        }
    }
}
