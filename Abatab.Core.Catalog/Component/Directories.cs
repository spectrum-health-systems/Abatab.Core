// Abatab.Core.Catalog.Component.Directories.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System.Collections.Generic;
using Abatab.Core.Catalog.Definition;

namespace Abatab.Core.Catalog.Component
{
    /// <summary>Summary goes here.</summary>
    public static class Directories
    {
        /// <summary>Summary goes here.</summary>
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

        /// <summary>Summary goes here.</summary>
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