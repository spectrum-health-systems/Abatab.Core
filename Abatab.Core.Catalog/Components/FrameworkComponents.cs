// Abatab.Core.Catalog.Components.FrameworkComponents.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System.Collections.Generic;

namespace Abatab.Core.Catalog.Components
{
    public static class FrameworkComponents
    {
        public static List<string> RequiredDirectories(SessionProperties sessionProperties)
        {
            return new List<string>()
            {
                sessionProperties.AbatabDataRoot,
                sessionProperties.SessionDataRoot,
                sessionProperties.TraceLogDirectory,
                sessionProperties.WarningLogDirectory,
                sessionProperties.PublicDataRoot,
                sessionProperties.PublicWarningLogDirectory,
                sessionProperties.DebugglerLogDirectory
            };
        }
    }
}