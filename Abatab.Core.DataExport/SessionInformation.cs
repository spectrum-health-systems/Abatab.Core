// Abatab.Core.DataExport.SessionDetails.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using Abatab.Core.Catalog;

namespace Abatab.Core.DataExport
{
    public static class SessionInformation
    {
        public static void ToSessionRoot(SessionProperties sessionProperties)
        {
            DataWriter.LocalFile($@"{sessionProperties.SessionDataRoot}\session.md", Catalog.SessionInformation.BuildSessionInformationFull(sessionProperties));
        }

        public static void ToDaily(SessionProperties sessionProperties, string filePath)
        {
            DataWriter.LocalFile($@"{filePath}", Catalog.SessionInformation.BuildSessionInformationFull(sessionProperties));
        }
    }
}
