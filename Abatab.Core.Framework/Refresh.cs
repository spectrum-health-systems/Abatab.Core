using Abatab.Core.Catalog;
using Abatab.Core.Catalog.Components;

namespace Abatab.Core.Framework
{
    public class Refresh
    {
        public static void Daily(SessionProperties sessionProperties)
        {
            Verify.DirectoriesExist(FrameworkComponents.RequiredDirectories(sessionProperties));
            Core.DataExport.SessionInformation.ToDaily(sessionProperties, $@"{sessionProperties.AbatabDataRoot}\{sessionProperties.AvatarEnvironment}\Abatab-settings.md");


        }
    }
}
