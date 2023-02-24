using System.Collections.Generic;

namespace Abatab.Core.Catalog
{
    public class FrameworkComponents
    {
        public static List<string> RequiredDirectories(SessionProperties sessionProperties)
        {
            return new List<string>()
            {
                sessionProperties.AbatabDataRoot,
                sessionProperties.SessionDataRoot,
                sessionProperties.WarningLogDirectory,
                sessionProperties.PublicDataRoot,
                sessionProperties.PublicWarningLogDirectory,
                sessionProperties.DebugglerLogDirectory
            };
        }
    }
}