// Abatab.Core.Catalog.Component.Information.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System;
using Abatab.Core.Catalog.Definition;

namespace Abatab.Core.Catalog.Component
{
    /// <summary>Class description goes here.</summary>
    public static class Information
    {
        public static string DailySettingInformation(AbSession abSession)
        {
            return Detail.AbatabSettingsDetail(abSession) +
                   Environment.NewLine +
                   ModuleInformationFull(abSession);
        }

        public static string SessionInformationBasic(AbSession abSession)
        {
            return Detail.AbatabDetailFull(abSession);
        }

        public static string SessionInformationFull(AbSession abSession)
        {
            return Detail.AbatabDetailFull(abSession) +
                   Environment.NewLine +
                   ModuleInformationFull(abSession) +
                   Environment.NewLine +
                   OptionObjectInformationFull(abSession);
        }

        public static string SessionInformationTargeted(AbSession abSession)
        {
            return "TODO";
        }

        public static string OptionObjectInformationFull(AbSession abSession)
        {
            return "# OptionObject details" +
                   Environment.NewLine +
                   Detail.SentOptionObjectDetail(abSession) +
                   Environment.NewLine +
                   Detail.ReturnOptionObjectDetail(abSession) +
                   Environment.NewLine;
        }

        public static string ModuleInformationFull(AbSession abSession)
        {
            return "# Module details" +
                   Environment.NewLine +
                   Detail.ModProgressNoteDetail(abSession) +
                   Environment.NewLine +
                   Detail.ModPrototypeDetail(abSession) +
                   Environment.NewLine +
                   Detail.ModQuickMedicationOrderDetail(abSession) +
                   Environment.NewLine +
                   Detail.ModTestingDetail(abSession);
        }
    }
}