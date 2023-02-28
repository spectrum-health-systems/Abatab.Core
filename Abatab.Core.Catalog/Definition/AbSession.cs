// Abatab.Core.Catalog.SessionProperties.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System.Collections.Generic;
using ScriptLinkStandard.Objects;

namespace Abatab.Core.Catalog.Definition
{
    public class AbSession
    {
        // Local settings from Web.config.
        public string AbatabMode { get; set; }
        public string AbatabVersion { get; set; }
        public string AbatabBuild { get; set; }
        public string AbatabServiceRoot { get; set; }
        public string AbatabDataRoot { get; set; }
        public string LoggerMode { get; set; }
        public string LoggerTypes { get; set; }
        public string LoggerDelay { get; set; }
        public string AvatarEnvironment { get; set; }
        public string AbatabFallbackUserName { get; set; }
        public string DebugglerMode { get; set; }

        // Runtime settings.
        public string Datestamp { get; set; }
        public string Timestamp { get; set; }
        public string RequestModule { get; set; }
        public string RequestCommand { get; set; }
        public string RequestAction { get; set; }
        public string RequestOption { get; set; }
        public string AbatabUserName { get; set; }
        public string SessionDataRoot { get; set; }
        public string SessionDataDirectory { get; set; }
        public string TraceLogDirectory { get; set; }
        public string WarningLogDirectory { get; set; }
        public string PublicDataRoot { get; set; }
        public string PublicWarningLogDirectory { get; set; }
        public string DebugglerLogDirectory { get; set; }

        // OptionObject settings.
        public OptionObject2015 SentOptionObject { get; set; }
        public OptionObject2015 ReturnOptionObject { get; set; }

        // Module settings.
        public ModProgressNote ModProgressNote { get; set; }
        public ModPrototype ModPrototype { get; set; }
        public ModQuickMedicationOrder ModQuickMedicationOrder { get; set; }
        public ModTesting ModTesting { get; set; }
    }

    public class ModProgressNote
    {
        public string Mode { get; set; }
        public string AuthorizedUsers { get; set; }
        public string ServiceChargeCodeFieldId { get; set; }
        public List<string> ServiceChargeCodesCheck { get; set; }
        public string LocationFieldId { get; set; }
        public List<string> ValidLocations { get; set; }
    }

    public class ModPrototype
    {
        public string Mode { get; set; }
        public string AuthorizedUsers { get; set; }
    }

    public class ModQuickMedicationOrder
    {
        public string Mode { get; set; }
        public string AuthorizedUsers { get; set; }
        public string ValidOrderTypes { get; set; }
        public string DosePercentBoundary { get; set; }
        public string DoseMilligramBoundary { get; set; }
    }

    public class ModTesting
    {
        public string Mode { get; set; }
    }
}