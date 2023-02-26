// Abatab.Core.DataExport.SessionDetails.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System;
using Abatab.Core.Catalog.Definition;

namespace Abatab.Core.DataExport
{
    public static class SessionInformation
    {
        public static void ToSessionRoot(AbSession abSession)
        {
            DataWriter.LocalFile($@"{abSession.SessionDataDirectory}\{DateTime.Now:HHmmss.ffffff}-session.md", Catalog.Component.Information.SessionInformationFull(abSession));
        }

        public static void DailyRefresh(AbSession abSession, string filePath)
        {
            DataWriter.LocalFile($@"{filePath}", Catalog.Component.Information.DailySettingInformation(abSession));
        }
    }
}
