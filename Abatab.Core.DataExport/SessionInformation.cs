// Abatab.Core.DataExport.SessionDetails.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System;
using System.Reflection;
using Abatab.Core.Catalog.Definition;
using Abatab.Core.Logger;

namespace Abatab.Core.DataExport
{
    public static class SessionInformation
    {
        public static void ToSessionRoot(AbSession abSession)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            DataWriter.LocalFile($@"{abSession.SessionDataDirectory}\{DateTime.Now:HHmmss.fffffff}-session.md", Catalog.Component.Information.SessionInformationFull(abSession));
        }

        public static void DailyRefresh(AbSession abSession, string filePath)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            DataWriter.LocalFile($@"{filePath}", Catalog.Component.Information.DailySettingInformation(abSession));
        }
    }
}
