// Abatab.Core.Session.Build.cs
// b230224.1700
// Copyright (c) A Pretty Cool Program

using System;
using System.Collections.Generic;
using System.Reflection;
using Abatab.Core.Catalog;
using Abatab.Core.Logger;
using ScriptLinkStandard.Objects;

namespace Abatab.Core.Session
{
    public static class Build
    {
        public static SessionProperties NewSession(OptionObject2015 sentOptionObject, string scriptParameter, Dictionary<string, string> webConfigContent)
        {
            SessionProperties sessionProperties = BuildAbatabDetail(webConfigContent);
            BuildSessionRuntimeDetail(sessionProperties);
            BuildSessionOptionObjectDetail(sessionProperties, sentOptionObject);
            BuildAbatabUserName(sessionProperties);
            BuildSessionFrameworkDetail(sessionProperties);
            BuildAbatabRequest(sessionProperties, scriptParameter);
            BuildModProgressNote(sessionProperties, webConfigContent);
            BuildModPrototype(sessionProperties, webConfigContent);
            BuildModQuickMedicationOrder(sessionProperties, webConfigContent);
            BuildModTesting(sessionProperties, webConfigContent);

            return sessionProperties;
        }

        public static SessionProperties BuildAbatabDetail(Dictionary<string, string> webConfigContent)
        {
            return new SessionProperties()
            {
                AbatabMode             = webConfigContent["AbatabMode"],
                AbatabServiceRoot      = webConfigContent["AbatabServiceRoot"],
                AbatabDataRoot         = webConfigContent["AbatabDataRoot"],
                LoggerMode             = webConfigContent["LoggerMode"],
                LoggerTypes            = webConfigContent["LoggerTypes"],
                LoggerDelay            = webConfigContent["LoggerDelay"],
                AvatarEnvironment      = webConfigContent["AvatarEnvironment"],
                AbatabFallbackUserName = webConfigContent["AbatabFallbackUserName"],
                DebugglerMode          = webConfigContent["DebugglerMode"]
            };
        }

        public static void BuildSessionRuntimeDetail(SessionProperties sessionProperties)
        {
            LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);

            sessionProperties.Datestamp = $"{DateTime.Now:yyMMdd}";
            sessionProperties.Timestamp = $"{DateTime.Now:HHmmss}";
        }


        public static void BuildSessionOptionObjectDetail(SessionProperties sessionProperties, OptionObject2015 sentOptionObject)
        {
            LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);

            sessionProperties.SentOptionObject   = sentOptionObject;
            sessionProperties.ReturnOptionObject = new OptionObject2015();
        }

        public static void BuildAbatabUserName(SessionProperties sessionProperties)
        {
            LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);

            sessionProperties.AbatabUserName = string.IsNullOrWhiteSpace(sessionProperties.SentOptionObject.OptionUserId)
                ? sessionProperties.AbatabFallbackUserName
                : sessionProperties.SentOptionObject.OptionUserId;
        }

        public static void BuildSessionFrameworkDetail(SessionProperties sessionProperties)
        {
            LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);

            sessionProperties.SessionDataRoot           = $@"{sessionProperties.AbatabDataRoot}\{sessionProperties.AvatarEnvironment}\{sessionProperties.Datestamp}\{sessionProperties.AbatabUserName}\{sessionProperties.Timestamp}";
            sessionProperties.TraceLogDirectory         = $@"{sessionProperties.SessionDataRoot}\trace";
            sessionProperties.WarningLogDirectory       = $@"{sessionProperties.SessionDataRoot}\warnings";
            sessionProperties.PublicDataRoot            = $@"{sessionProperties.AbatabDataRoot}\public\";
            sessionProperties.PublicWarningLogDirectory = $@"{sessionProperties.AbatabDataRoot}\public\warnings";
            sessionProperties.DebugglerLogDirectory     = $@"{sessionProperties.AbatabDataRoot}\debuggler";

            Framework.Verify.RequiredDirectories(FrameworkComponents.RequiredDirectories(sessionProperties));
        }

        // TODO - This is where things are broken - 230224 5:15pm

        public static void BuildAbatabRequest(SessionProperties sessionProperties, string scriptParameter)
        {
            LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);

            string[] parameterComponent = scriptParameter.ToLower().Split('-');

            sessionProperties.RequestModule  = parameterComponent[0].Trim().ToLower();
            sessionProperties.RequestCommand = parameterComponent[2].Trim().ToLower();
            sessionProperties.RequestAction  = parameterComponent[3].Trim().ToLower();

            if (parameterComponent.Length == 4)
            {
                LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);
                sessionProperties.RequestOption = parameterComponent[3].ToLower();
            }
        }

        private static void BuildModProgressNote(SessionProperties sessionProperties, Dictionary<string, string> webConfigContent)
        {
            LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);

            sessionProperties.ModProgressNote.Mode            = webConfigContent["ModProgressNoteMode"];
            sessionProperties.ModProgressNote.AuthorizedUsers = webConfigContent["ModProgressNoteAuthorizedUser"];
        }

        private static void BuildModPrototype(SessionProperties sessionProperties, Dictionary<string, string> webConfigContent)
        {
            LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);

            sessionProperties.ModPrototype.Mode            = webConfigContent["ModProgressNoteMode"];
            sessionProperties.ModPrototype.AuthorizedUsers = webConfigContent["ModProgressNoteAuthorizedUser"];
        }

        private static void BuildModQuickMedicationOrder(SessionProperties sessionProperties, Dictionary<string, string> webConfigContent)
        {
            LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);

            sessionProperties.ModQuickMedicationOrder.Mode                  = webConfigContent["ModQuickMedicationOrderMode"];
            sessionProperties.ModQuickMedicationOrder.AuthorizedUsers       = webConfigContent["ModQuickMedicationOrderAuthorizedUser"];
            sessionProperties.ModQuickMedicationOrder.ValidOrderType        = webConfigContent["ModQuickMedicationOrderValidOrderType"];
            sessionProperties.ModQuickMedicationOrder.DosePercentBoundary   = webConfigContent["ModQuickMedicationOrderDosePercentBoundary"];
            sessionProperties.ModQuickMedicationOrder.DoseMilligramBoundary = webConfigContent["ModQuickMedicationOrderDoseMilligramBoundary"];
        }
        private static void BuildModTesting(SessionProperties sessionProperties, Dictionary<string, string> webConfigContent)
        {
            LogEvent.Trace(sessionProperties, Assembly.GetExecutingAssembly().GetName().Name);

            sessionProperties.ModTesting.Mode = webConfigContent["ModTestingMode"];
        }
    }
}