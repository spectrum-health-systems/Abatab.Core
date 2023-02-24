// Abatab.Core.Catalog.FrameworkComponents.cs
// b230224.1700
// Copyright (c) A Pretty Cool Program

using System.Collections.Generic;

namespace Abatab.Core.Catalog
{
    public static class FrameworkComponents
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