// Abatab.Core.DataExport.SessionInformation.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System;
using System.Reflection;
using Abatab.Core.Catalog.Definition;
using Abatab.Core.Logger;

namespace Abatab.Core.DataExport
{
    /// <summary>Summary goes here.</summary>
    public static class SessionInformation
    {
        /// <summary>Summary goes here.</summary>
        public static void ToSessionRoot(AbSession abSession)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            DataWriter.LocalFile($@"{abSession.SessionDataDirectory}\{DateTime.Now:HHmmss.fffffff}-session.md", Catalog.Component.Information.SessionInformationFull(abSession));
        }

        /// <summary>Summary goes here.</summary>
        public static void DailyRefresh(AbSession abSession, string filePath)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            DataWriter.LocalFile($@"{filePath}", Catalog.Component.Information.DailySettingInformation(abSession));
        }
    }
}
