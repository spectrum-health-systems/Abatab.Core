using System.Collections.Generic;
using Abatab.Core.Catalog.Definition;

namespace Abatab.Core.Catalog.Component
{
    public static class Directories
    {
        public static List<string> ForFramework(AbSession abSession)
        {
            return new List<string>()
            {
                abSession.AbatabDataRoot,
                abSession.SessionDataDirectory,
                abSession.PublicDataRoot,
                abSession.PublicWarningLogDirectory,
                abSession.DebugglerLogDirectory
            };
        }

        public static List<string> ForSession(AbSession abSession)
        {
            return new List<string>()
            {
                abSession.SessionDataDirectory,
                abSession.TraceLogDirectory,
                abSession.WarningLogDirectory
            };
        }
    }
}
