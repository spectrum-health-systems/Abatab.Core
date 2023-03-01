// Abatab.Core.Catalog.Definition.AbSession.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System.Collections.Generic;
using ScriptLinkStandard.Objects;

namespace Abatab.Core.Catalog.Definition
{
    /// <summary>Summary goes here.</summary>
    public class AbSession
    {
        /* Local settings from Web.config. */

        /// <summary>Summary goes here.</summary>
        public string AbatabMode { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AbatabVersion { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AbatabBuild { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AbatabServiceRoot { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AbatabDataRoot { get; set; }

        /// <summary>Summary goes here.</summary>
        public string LoggerMode { get; set; }

        /// <summary>Summary goes here.</summary>
        public string LoggerTypes { get; set; }

        /// <summary>Summary goes here.</summary>
        public string LoggerDelay { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AvatarEnvironment { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AbatabFallbackUserName { get; set; }

        /// <summary>Summary goes here.</summary>
        public string DebugglerMode { get; set; }

        /*  Runtime settings. */

        /// <summary>Summary goes here.</summary>
        public string Datestamp { get; set; }

        /// <summary>Summary goes here.</summary>
        public string Timestamp { get; set; }

        /// <summary>Summary goes here.</summary>
        public string RequestModule { get; set; }

        /// <summary>Summary goes here.</summary>
        public string RequestCommand { get; set; }

        /// <summary>Summary goes here.</summary>
        public string RequestAction { get; set; }

        /// <summary>Summary goes here.</summary>
        public string RequestOption { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AbatabUserName { get; set; }

        /// <summary>Summary goes here.</summary>
        public string SessionDataRoot { get; set; }

        /// <summary>Summary goes here.</summary>
        public string SessionDataDirectory { get; set; }

        /// <summary>Summary goes here.</summary>
        /// 
        /// <summary>Summary goes here.</summary>
        /// 
        /// <summary>Summary goes here.</summary>
        public string TraceLogDirectory { get; set; }

        /// <summary>Summary goes here.</summary>
        public string WarningLogDirectory { get; set; }

        /// <summary>Summary goes here.</summary>
        public string PublicDataRoot { get; set; }

        /// <summary>Summary goes here.</summary>
        public string PublicWarningLogDirectory { get; set; }

        /// <summary>Summary goes here.</summary>
        public string DebugglerLogDirectory { get; set; }

        /* OptionObject settings. */

        /// <summary>Summary goes here.</summary>
        public OptionObject2015 SentOptionObject { get; set; }

        /// <summary>Summary goes here.</summary>
        public OptionObject2015 ReturnOptionObject { get; set; }

        /* Module settings. */

        /// <summary>Summary goes here.</summary>
        public ModProgressNote ModProgressNote { get; set; }

        /// <summary>Summary goes here.</summary>
        public ModPrototype ModPrototype { get; set; }

        /// <summary>Summary goes here.</summary>
        public ModQuickMedicationOrder ModQuickMedicationOrder { get; set; }

        /// <summary>Summary goes here.</summary>
        public ModTesting ModTesting { get; set; }
    }

    /// <summary>Summary goes here.</summary>
    public class ModProgressNote
    {
        /// <summary>Summary goes here.</summary>
        public string Mode { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AuthorizedUsers { get; set; }

        /// <summary>Summary goes here.</summary>
        public string ServiceChargeCodeFieldId { get; set; }

        /// <summary>Summary goes here.</summary>
        public List<string> ServiceChargeCodesCheck { get; set; }

        /// <summary>Summary goes here.</summary>
        public string LocationFieldId { get; set; }

        /// <summary>Summary goes here.</summary>
        public List<string> ValidLocations { get; set; }
    }

    /// <summary>Summary goes here.</summary>
    public class ModPrototype
    {
        /// <summary>Summary goes here.</summary>
        public string Mode { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AuthorizedUsers { get; set; }
    }

    /// <summary>Summary goes here.</summary>
    public class ModQuickMedicationOrder
    {
        /// <summary>Summary goes here.</summary>
        public string Mode { get; set; }

        /// <summary>Summary goes here.</summary>
        public string AuthorizedUsers { get; set; }

        /// <summary>Summary goes here.</summary>
        public string ValidOrderTypes { get; set; }

        /// <summary>Summary goes here.</summary>
        public string DosePercentBoundary { get; set; }

        /// <summary>Summary goes here.</summary>
        public string DoseMilligramBoundary { get; set; }
    }

    /// <summary>Summary goes here.</summary>
    public class ModTesting
    {
        /// <summary>Summary goes here.</summary>
        public string Mode { get; set; }
    }
}