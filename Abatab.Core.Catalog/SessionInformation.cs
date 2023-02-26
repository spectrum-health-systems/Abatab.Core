// Abatab.Core.Catalog.SessionInformation.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System;

namespace Abatab.Core.Catalog
{
    public static class SessionInformation
    {
        public static string BuildSessionInformationBasic(SessionProperties sessionProperties) =>
            ComponentDetail.BuildAbatabDetail(sessionProperties);

        public static string BuildSessionInformationFull(SessionProperties sessionProperties) =>
            ComponentDetail.BuildAbatabDetail(sessionProperties) + Environment.NewLine +
            BuildModuleInformation(sessionProperties) + Environment.NewLine +
            BuildOptionObjectInformation(sessionProperties);

        public static string BuildModuleInformation(SessionProperties sessionProperties) =>
           ComponentDetail.BuildModProgressNoteDetail(sessionProperties) + Environment.NewLine +
           ComponentDetail.BuildModPrototypeDetail(sessionProperties) + Environment.NewLine +
           ComponentDetail.BuildModQuickMedicationOrderDetail(sessionProperties) +  Environment.NewLine +
           ComponentDetail.BuildModTestingDetail(sessionProperties);

        private static string BuildOptionObjectInformation(SessionProperties sessionProperties) =>
            $"# OptionObjects{Environment.NewLine}" +
            ComponentDetail.BuildSentOptionObjectDetail(sessionProperties) + Environment.NewLine +
            ComponentDetail.BuildReturnOptionObjectDetail(sessionProperties);
    }
}