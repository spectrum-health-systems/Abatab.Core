// Abatab.Core.Catalog.Component.Detail.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System;
using Abatab.Core.Catalog.Definition;

namespace Abatab.Core.Catalog.Component
{
    /// <summary>Summary goes here.</summary>
    public static class Detail
    {
        /// <summary>Summary goes here.</summary>
        public static string AbatabSettingsDetail(AbSession abSession)
        {
            return $"# Abatab Settings{Environment.NewLine}" +
                   $">These settings are current as of {abSession.Datestamp}.{abSession.Timestamp} {Environment.NewLine}" +
                   $"{Environment.NewLine}" +
                   $"**Avatar version:** {abSession.AbatabVersion} {abSession.AbatabBuild}  {Environment.NewLine}" +
                   $"**Abatab mode:** {abSession.AbatabMode}  {Environment.NewLine}" +
                   $"**Avatar environment:** {abSession.AvatarEnvironment}  {Environment.NewLine}" +
                   $"**Abatab fallback username:** {abSession.AbatabFallbackUserName}  {Environment.NewLine}" +
                   $"**Abatab service root:** {abSession.AbatabServiceRoot}  {Environment.NewLine}" +
                   $@"**Abatab data root:** {abSession.AbatabDataRoot}\  {Environment.NewLine}" +
                   $"**Session data root:** {abSession.SessionDataRoot}  {Environment.NewLine}" +
                   $"**Debuggler mode:** {abSession.DebugglerMode}  {Environment.NewLine}" +
                   $"**Debuggler log directory:** {abSession.DebugglerLogDirectory}  {Environment.NewLine}" +
                   $"## Public data  {Environment.NewLine}" +
                   $"**Public data root:** {abSession.PublicDataRoot}  {Environment.NewLine}" +
                   $"**Public warning log directory:** {abSession.PublicWarningLogDirectory}  {Environment.NewLine}" +
                   $"## Logger  {Environment.NewLine}" +
                   $"**Logger mode:** {abSession.LoggerMode}  {Environment.NewLine}" +
                   $"**Logger types:** {abSession.LoggerTypes}  {Environment.NewLine}" +
                   $"**Logger delay:** {abSession.LoggerDelay}  {Environment.NewLine}" +
                   $"## Request  {Environment.NewLine}" +
                   $"**Request module:** {abSession.RequestModule}  {Environment.NewLine}" +
                   $"**Request command:** {abSession.RequestCommand}  {Environment.NewLine}" +
                   $"**Request action:** {abSession.RequestAction}  {Environment.NewLine}" +
                   $"**Request option:** {abSession.RequestOption}  {Environment.NewLine}";
        }

        /// <summary>Summary goes here.</summary>
        public static string AbatabDetailFull(AbSession abSession)
        {
            return $"# Abatab Session{Environment.NewLine}" +
                   $"**Avatar version:** {abSession.AbatabVersion}  {Environment.NewLine}" +
                   $"**Avatar build:** {abSession.AbatabBuild}  {Environment.NewLine}" +
                   $"**Avatar username:** {abSession.AbatabUserName}  {Environment.NewLine}" +
                   $"**Date:** {abSession.Datestamp}  {Environment.NewLine}" +
                   $"**Time:** {abSession.Timestamp}  {Environment.NewLine}" +
                   $"**Abatab mode:** {abSession.AbatabMode}  {Environment.NewLine}" +
                   $"**Avatar environment:** {abSession.AvatarEnvironment}  {Environment.NewLine}" +
                   $"**Abatab fallback username:** {abSession.AbatabFallbackUserName}  {Environment.NewLine}" +
                   $"**Abatab service root:** {abSession.AbatabServiceRoot}  {Environment.NewLine}" +
                   $"**Abatab data root:** {abSession.AbatabDataRoot}  {Environment.NewLine}" +
                   $"**Session data root:** {abSession.SessionDataDirectory}  {Environment.NewLine}" +
                   $"**Trace log directory:** {abSession.TraceLogDirectory}  {Environment.NewLine}" +
                   $"**Warning log directory:** {abSession.WarningLogDirectory}  {Environment.NewLine}" +
                   $"**Debuggler mode:** {abSession.DebugglerMode}  {Environment.NewLine}" +
                   $"**Debuggler log directory:** {abSession.DebugglerLogDirectory}  {Environment.NewLine}" +
                   $"## Public data  {Environment.NewLine}" +
                   $"**Public data root:** {abSession.PublicDataRoot}  {Environment.NewLine}" +
                   $"**Public warning log directory:** {abSession.PublicWarningLogDirectory}  {Environment.NewLine}" +
                   $"## Logger  {Environment.NewLine}" +
                   $"**Logger mode:** {abSession.LoggerMode}  {Environment.NewLine}" +
                   $"**Logger types:** {abSession.LoggerTypes}  {Environment.NewLine}" +
                   $"**Logger delay:** {abSession.LoggerDelay}  {Environment.NewLine}" +
                   $"## Request  {Environment.NewLine}" +
                   $"**Request module:** {abSession.RequestModule}  {Environment.NewLine}" +
                   $"**Request command:** {abSession.RequestCommand}  {Environment.NewLine}" +
                   $"**Request action:** {abSession.RequestAction}  {Environment.NewLine}" +
                   $"**Request option:** {abSession.RequestOption}  {Environment.NewLine}";
        }

        /// <summary>Summary goes here.</summary>
        public static string ModProgressNoteDetail(AbSession abSession)
        {
            return $"# Progress Note Module{Environment.NewLine}" +
                   $"**Progress Note mode:** {abSession.ModProgressNote.Mode}  {Environment.NewLine}" +
                   $"**Progress Note authorized users:** {abSession.ModProgressNote.AuthorizedUsers}  {Environment.NewLine}";
        }

        /// <summary>Summary goes here.</summary>
        public static string ModPrototypeDetail(AbSession abSession)
        {
            return $"# Prototype Module{Environment.NewLine}" +
                   $"**Prototype mode:** {abSession.ModPrototype.Mode}  {Environment.NewLine}" +
                   $"**Prototype authorized users:** {abSession.ModPrototype.AuthorizedUsers}  {Environment.NewLine}";
        }

        /// <summary>Summary goes here.</summary>
        public static string ModQuickMedicationOrderDetail(AbSession abSession)
        {
            return $"# QuickMedicationOrder Module{Environment.NewLine}" +
                   $"**QuickMedicationOrder mode:** {abSession.ModQuickMedicationOrder.Mode}  {Environment.NewLine}" +
                   $"**QuickMedicationOrder authorized users:** {abSession.ModQuickMedicationOrder.AuthorizedUsers}  {Environment.NewLine}" +
                   $"**QuickMedicationOrder valid order types:** {abSession.ModQuickMedicationOrder.ValidOrderTypes}  {Environment.NewLine}" +
                   $"**QuickMedicationOrder dose percent boundry:** {abSession.ModQuickMedicationOrder.DosePercentBoundary}  {Environment.NewLine}" +
                   $"**QuickMedicationOrder dose milligram boundry:** {abSession.ModQuickMedicationOrder.DoseMilligramBoundary}  {Environment.NewLine}";
        }

        /// <summary>Summary goes here.</summary>
        public static string ModTestingDetail(AbSession abSession)
        {
            return $"# Testing Module{Environment.NewLine}" +
                   $"**Testing mode:** {abSession.ModTesting.Mode}  {Environment.NewLine}";
        }

        /// <summary>Summary goes here.</summary>
        public static string SentOptionObjectDetail(AbSession abSession)
        {
            return $"## SentOptionObject{Environment.NewLine}" +
                   $"```{abSession.SentOptionObject.ToJson()}```  {Environment.NewLine}";
        }

        /// <summary>Summary goes here.</summary>
        public static string ReturnOptionObjectDetail(AbSession abSession)
        {
            return $"## ReturnOptionObject{Environment.NewLine}" +
                   $"```{abSession.ReturnOptionObject.ToJson()}```  {Environment.NewLine}";
        }
    }
}