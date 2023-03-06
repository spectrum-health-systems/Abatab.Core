// Abatab.Core.Session.Build.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System;
using System.Collections.Generic;
using System.Reflection;
using Abatab.Core.Catalog.Definition;
using Abatab.Core.Logger;
using ScriptLinkStandard.Objects;

namespace Abatab.Core.Session
{
    /// <summary>Summary goes here.</summary>
    public static class Build
    {
        /// <summary>Summary goes here.</summary>
        public static void NewSession(OptionObject2015 sentOptionObject, string scriptParameter, AbSession abSession)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            //BuildAbatabDetail(abSession);
            BuildSessionRuntimeDetail(abSession);
            BuildSessionOptionObjectDetail(abSession, sentOptionObject);
            BuildAbatabUserName(abSession);
            BuildSessionFrameworkDetail(abSession);
            BuildAbatabRequest(abSession, scriptParameter);
            BuildModProgressNote(abSession);
            //BuildModPrototype(abSession);
            //BuildModQuickMedicationOrder(abSession);
            //BuildModTesting(abSession);
        }

        //public static void BuildAbatabDetail(AbSession abSession, Dictionary<string, string> webConfigContent)
        //{
        //    Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

        //    abSession.AbatabMode             = webConfigContent["AbatabMode"];
        //    abSession.AbatabVersion          = webConfigContent["AbatabVersion"];
        //    abSession.AbatabBuild            = webConfigContent["AbatabBuild"];
        //    abSession.AbatabServiceRoot      = webConfigContent["AbatabServiceRoot"];
        //    abSession.AbatabDataRoot         = webConfigContent["AbatabDataRoot"];
        //    abSession.LoggerMode             = webConfigContent["LoggerMode"];
        //    abSession.LoggerTypes            = webConfigContent["LoggerTypes"];
        //    abSession.LoggerDelay            = webConfigContent["LoggerDelay"];
        //    abSession.AvatarEnvironment      = webConfigContent["AvatarEnvironment"];
        //    abSession.AbatabFallbackUserName = webConfigContent["AbatabFallbackUserName"];
        //    abSession.DebugglerMode          = webConfigContent["DebugglerMode"];

        //}

        /// <summary>Summary goes here.</summary>
        public static void BuildSessionRuntimeDetail(AbSession abSession)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            abSession.Datestamp = $"{DateTime.Now:yyMMdd}";
            abSession.Timestamp = $"{DateTime.Now:HHmmss}";
        }

        /// <summary>Summary goes here.</summary>
        public static void BuildSessionOptionObjectDetail(Catalog.Definition.AbSession abSession, OptionObject2015 sentOptionObject)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            abSession.SentOptionObject   = sentOptionObject;
            abSession.ReturnOptionObject = sentOptionObject.Clone();
        }

        /// <summary>Summary goes here.</summary>
        public static void BuildAbatabUserName(AbSession abSession)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            abSession.AbatabUserName = string.IsNullOrWhiteSpace(abSession.SentOptionObject.OptionUserId)
                ? abSession.AbatabFallbackUserName
                : abSession.SentOptionObject.OptionUserId;
        }

        /// <summary>Summary goes here.</summary>
        public static void BuildSessionFrameworkDetail(AbSession abSession)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            abSession.SessionDataRoot           = $@"{abSession.AbatabDataRoot}\{abSession.AvatarEnvironment}\{abSession.Datestamp}";
            abSession.SessionDataDirectory      = $@"{abSession.AbatabDataRoot}\{abSession.AvatarEnvironment}\{abSession.Datestamp}\User\{abSession.AbatabUserName}\{abSession.Timestamp}";
            abSession.TraceLogDirectory         = $@"{abSession.SessionDataDirectory}\trace";
            abSession.WarningLogDirectory       = $@"{abSession.SessionDataDirectory}\warnings";
            abSession.PublicDataRoot            = $@"{abSession.AbatabDataRoot}\public\";
            abSession.PublicWarningLogDirectory = $@"{abSession.AbatabDataRoot}\public\warnings";
            abSession.DebugglerLogDirectory     = $@"{abSession.AbatabDataRoot}\debuggler";

            Framework.Verify.DirectoriesExist(Catalog.Component.Directories.ForSession(abSession));

        }

        /// <summary>Summary goes here.</summary>
        public static void BuildAbatabRequest(AbSession abSession, string scriptParameter)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            string[] parameterComponent = scriptParameter.ToLower().Split('-');

            abSession.RequestModule  = parameterComponent[0].Trim().ToLower();
            abSession.RequestCommand = parameterComponent[1].Trim().ToLower();
            abSession.RequestAction  = parameterComponent[2].Trim().ToLower();

            if (parameterComponent.Length == 4)
            {
                LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);
                abSession.RequestOption = parameterComponent[3].ToLower();
            }
        }

        /// <summary>Summary goes here.</summary>
        private static void BuildModProgressNote(AbSession abSession)
        {
            LogEvent.Trace(abSession, Assembly.GetExecutingAssembly().GetName().Name);

            abSession.ModProgressNote.ServiceChargeCodeFieldId  = "51001";
            abSession.ModProgressNote.ServiceChargeCodePrefixes = new List<string>()
            {
                "TMH",
                "AOTMH"
            };
            abSession.ModProgressNote.ServiceChargeCodesCheck  = new List<string>()
            {
                "TMH90853",
                "AOTMH90853"
            };

            abSession.ModProgressNote.LocationFieldId = "50004";
            abSession.ModProgressNote.ValidLocations  = new List<string>()
            {
                "T110",
                "T102"
            };
        }

        //private static void BuildModPrototype(AbSession abSession, Dictionary<string, string> webConfigContent)
        //{
        //    Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

        //    abSession.ModPrototype = new ModPrototype
        //    {
        //        Mode            = webConfigContent["ModProgressNoteMode"],
        //        AuthorizedUsers = webConfigContent["ModProgressNoteAuthorizedUsers"]
        //    };
        //}

        //private static void BuildModQuickMedicationOrder(AbSession abSession, Dictionary<string, string> webConfigContent)
        //{
        //    Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

        //    abSession.ModQuickMedicationOrder = new ModQuickMedicationOrder
        //    {
        //        Mode                  = webConfigContent["ModQuickMedicationOrderMode"],
        //        AuthorizedUsers       = webConfigContent["ModQuickMedicationOrderAuthorizedUsers"],
        //        ValidOrderTypes       = webConfigContent["ModQuickMedicationOrderValidOrderTypes"],
        //        DosePercentBoundary   = webConfigContent["ModQuickMedicationOrderDosePercentBoundary"],
        //        DoseMilligramBoundary = webConfigContent["ModQuickMedicationOrderDoseMilligramBoundary"]
        //    };
        //}

        //private static void BuildModTesting(AbSession abSession, Dictionary<string)
        //{
        //    Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);
        //}
    }
}