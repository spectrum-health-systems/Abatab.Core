// Abatab.Core.Framework.Refresh.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System.Reflection;
using Abatab.Core.Catalog.Definition;
using Abatab.Core.Logger;

namespace Abatab.Core.Framework
{
    /// <summary>Summary goes here.</summary>
    public static class Refresh
    {
        /// <summary>Summary goes here.</summary>
        public static void Daily(AbSession abSession)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            Verify.DirectoriesExist(Abatab.Core.Catalog.Component.Directories.ForFramework(abSession));
            Core.DataExport.SessionInformation.DailyRefresh(abSession, $@"{abSession.AbatabDataRoot}\{abSession.AvatarEnvironment}\Abatab current settings.md");
        }
    }
}
