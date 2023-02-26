// Abatab.Core.Session.Build.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System;
using System.Collections.Generic;
using System.Reflection;
using Abatab.Core.Catalog.Definition;
using Abatab.Core.Logger;
using Abatab.Core.Utilities;
using ScriptLinkStandard.Objects;

namespace Abatab.Core.Session
{
    public static class Build
    {
        public static void NewSession(OptionObject2015 sentOptionObject, string scriptParameter, AbSession abSession, Dictionary<string, string> webConfigContent)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            BuildAbatabDetail(abSession, webConfigContent);
            BuildSessionRuntimeDetail(abSession);
            BuildSessionOptionObjectDetail(abSession, sentOptionObject);
            BuildAbatabUserName(abSession);
            BuildSessionFrameworkDetail(abSession);
            BuildAbatabRequest(abSession, scriptParameter);
            BuildModProgressNote(abSession, webConfigContent);
            BuildModPrototype(abSession, webConfigContent);
            BuildModQuickMedicationOrder(abSession, webConfigContent);
            BuildModTesting(abSession, webConfigContent);
        }

        public static void BuildAbatabDetail(AbSession abSession, Dictionary<string, string> webConfigContent)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            abSession.AbatabMode             = webConfigContent["AbatabMode"];
            abSession.AbatabVersion          = webConfigContent["AbatabVersion"];
            abSession.AbatabBuild            = webConfigContent["AbatabBuild"];
            abSession.AbatabServiceRoot      = webConfigContent["AbatabServiceRoot"];
            abSession.AbatabDataRoot         = webConfigContent["AbatabDataRoot"];
            abSession.LoggerMode             = webConfigContent["LoggerMode"];
            abSession.LoggerTypes            = webConfigContent["LoggerTypes"];
            abSession.LoggerDelay            = webConfigContent["LoggerDelay"];
            abSession.AvatarEnvironment      = webConfigContent["AvatarEnvironment"];
            abSession.AbatabFallbackUserName = webConfigContent["AbatabFallbackUserName"];
            abSession.DebugglerMode          = webConfigContent["DebugglerMode"];

        }

        public static void BuildSessionRuntimeDetail(Catalog.Definition.AbSession abSession)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            abSession.Datestamp = $"{DateTime.Now:yyMMdd}";
            abSession.Timestamp = $"{DateTime.Now:HHmmss}";
        }


        public static void BuildSessionOptionObjectDetail(Catalog.Definition.AbSession abSession, OptionObject2015 sentOptionObject)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            abSession.SentOptionObject   = sentOptionObject;
            abSession.ReturnOptionObject = sentOptionObject.Clone();
        }

        public static void BuildAbatabUserName(Catalog.Definition.AbSession abSession)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            abSession.AbatabUserName = string.IsNullOrWhiteSpace(abSession.SentOptionObject.OptionUserId)
                ? abSession.AbatabFallbackUserName
                : abSession.SentOptionObject.OptionUserId;
        }

        public static void BuildSessionFrameworkDetail(Catalog.Definition.AbSession abSession)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            abSession.SessionDataRoot           = $@"{abSession.AbatabDataRoot}\{abSession.AvatarEnvironment}\{abSession.Datestamp}";
            abSession.SessionDataDirectory      = $@"{abSession.AbatabDataRoot}\{abSession.AvatarEnvironment}\{abSession.Datestamp}\User\{abSession.AbatabUserName}\{abSession.Timestamp}";
            abSession.TraceLogDirectory         = $@"{abSession.SessionDataDirectory}\trace";
            abSession.WarningLogDirectory       = $@"{abSession.SessionDataDirectory}\warnings";
            abSession.PublicDataRoot            = $@"{abSession.AbatabDataRoot}\public\";
            abSession.PublicWarningLogDirectory = $@"{abSession.AbatabDataRoot}\public\warnings";
            abSession.DebugglerLogDirectory     = $@"{abSession.AbatabDataRoot}\debuggler";

            Abatab.Core.Framework.Verify.DirectoriesExist(Abatab.Core.Catalog.Component.Directories.ForSession(abSession));

        }

        public static void BuildAbatabRequest(Catalog.Definition.AbSession abSession, string scriptParameter)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

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

        private static void BuildModProgressNote(Catalog.Definition.AbSession abSession, Dictionary<string, string> webConfigContent)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            abSession.ModProgressNote = new ModProgressNote
            {
                Mode            = webConfigContent["ModProgressNoteMode"],
                AuthorizedUsers = webConfigContent["ModProgressNoteAuthorizedUsers"]
            };
        }

        private static void BuildModPrototype(Catalog.Definition.AbSession abSession, Dictionary<string, string> webConfigContent)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            abSession.ModPrototype = new ModPrototype
            {
                Mode            = webConfigContent["ModProgressNoteMode"],
                AuthorizedUsers = webConfigContent["ModProgressNoteAuthorizedUsers"]
            };
        }

        private static void BuildModQuickMedicationOrder(Catalog.Definition.AbSession abSession, Dictionary<string, string> webConfigContent)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            abSession.ModQuickMedicationOrder = new ModQuickMedicationOrder
            {
                Mode                  = webConfigContent["ModQuickMedicationOrderMode"],
                AuthorizedUsers       = webConfigContent["ModQuickMedicationOrderAuthorizedUsers"],
                ValidOrderTypes       = webConfigContent["ModQuickMedicationOrderValidOrderTypes"],
                DosePercentBoundary   = webConfigContent["ModQuickMedicationOrderDosePercentBoundary"],
                DoseMilligramBoundary = webConfigContent["ModQuickMedicationOrderDoseMilligramBoundary"]
            };
        }

        private static void BuildModTesting(Catalog.Definition.AbSession abSession, Dictionary<string, string> webConfigContent)
        {
            Debuggler.WriteLocal(Assembly.GetExecutingAssembly().GetName().Name);

            abSession.ModTesting = new ModTesting
            {
                Mode = webConfigContent["ModTestingMode"]
            };
        }
    }
}