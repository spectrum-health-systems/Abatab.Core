// Abatab.Core.Catalog.ComponentDetail.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System;

namespace Abatab.Core.Catalog
{
    public static class ComponentDetail
    {
        public static string BuildAbatabDetail(SessionProperties sessionProperties) =>
            $"# Abatab Session{Environment.NewLine}" +
            $"**Avatar username:** {sessionProperties.AbatabUserName}  {Environment.NewLine}" +
            $"**Date:** {sessionProperties.Datestamp}  {Environment.NewLine}" +
            $"**Time:** {sessionProperties.Timestamp}  {Environment.NewLine}" +
            $"**Abatab mode:** {sessionProperties.AbatabMode}  {Environment.NewLine}" +
            $"**Avatar environment:** {sessionProperties.AvatarEnvironment}  {Environment.NewLine}" +
            $"**Abatab fallback username:** {sessionProperties.AbatabFallbackUserName}  {Environment.NewLine}" +
            $"**Abatab service root:** {sessionProperties.AbatabServiceRoot}  {Environment.NewLine}" +
            $"**Abatab data root:** {sessionProperties.AbatabDataRoot}  {Environment.NewLine}" +
            $"**Session data root:** {sessionProperties.SessionDataRoot}  {Environment.NewLine}" +
            $"**Trace log directory:** {sessionProperties.TraceLogDirectory}  {Environment.NewLine}" +
            $"**Warning log directory:** {sessionProperties.WarningLogDirectory}  {Environment.NewLine}" +
            $"**Debuggler mode:** {sessionProperties.DebugglerMode}  {Environment.NewLine}" +
            $"**Debuggler log directory:** {sessionProperties.DebugglerLogDirectory}  {Environment.NewLine}" +
            $"## Public data  {Environment.NewLine}" +
            $"**Public data root:** {sessionProperties.PublicDataRoot}  {Environment.NewLine}" +
            $"**Public warning log directory:** {sessionProperties.PublicWarningLogDirectory}  {Environment.NewLine}" +
            $"## Logger  {Environment.NewLine}" +
            $"**Logger mode:** {sessionProperties.LoggerMode}  {Environment.NewLine}" +
            $"**Logger types:** {sessionProperties.LoggerTypes}  {Environment.NewLine}" +
            $"**Logger delay:** {sessionProperties.LoggerDelay}  {Environment.NewLine}" +
            $"## Request  {Environment.NewLine}" +
            $"**Request module:** {sessionProperties.RequestModule}  {Environment.NewLine}" +
            $"**Request command:** {sessionProperties.RequestCommand}  {Environment.NewLine}" +
            $"**Request action:** {sessionProperties.RequestAction}  {Environment.NewLine}" +
            $"**Request option:** {sessionProperties.RequestOption}  {Environment.NewLine}";

        public static string BuildModProgressNoteDetail(SessionProperties sessionProperties) =>
            $"# Progress Note Module{Environment.NewLine}" +
            $"**Progress Note mode:** {sessionProperties.ModProgressNote.Mode}  {Environment.NewLine}" +
            $"**Progress Note authorized users:** {sessionProperties.ModProgressNote.AuthorizedUsers}  {Environment.NewLine}";

        public static string BuildModPrototypeDetail(SessionProperties sessionProperties) =>
            $"# Prototype Module{Environment.NewLine}" +
            $"**Prototype mode:** {sessionProperties.ModPrototype.Mode}  {Environment.NewLine}" +
            $"**Prototype authorized users:** {sessionProperties.ModPrototype.AuthorizedUsers}  {Environment.NewLine}";

        public static string BuildModQuickMedicationOrderDetail(SessionProperties sessionProperties) =>
            $"# QuickMedicationOrder Module{Environment.NewLine}" +
            $"**QuickMedicationOrder mode:** {sessionProperties.ModQuickMedicationOrder.Mode}  {Environment.NewLine}" +
            $"**QuickMedicationOrder authorized users:** {sessionProperties.ModQuickMedicationOrder.AuthorizedUsers}  {Environment.NewLine}" +
            $"**QuickMedicationOrder valid order types:** {sessionProperties.ModQuickMedicationOrder.ValidOrderTypes}  {Environment.NewLine}" +
            $"**QuickMedicationOrder dose percent boundry:** {sessionProperties.ModQuickMedicationOrder.DosePercentBoundary}  {Environment.NewLine}" +
            $"**QuickMedicationOrder dose milligram boundry:** {sessionProperties.ModQuickMedicationOrder.DoseMilligramBoundary}  {Environment.NewLine}";

        public static string BuildModTestingDetail(SessionProperties sessionProperties) =>
            $"# Testing Module{Environment.NewLine}" +
            $"**Testing mode:** {sessionProperties.ModTesting.Mode}  {Environment.NewLine}";

        public static string BuildSentOptionObjectDetail(SessionProperties sessionProperties) =>
            $"## SentOptionObject{Environment.NewLine}" +
            $"```{sessionProperties.SentOptionObject.ToJson()}```  {Environment.NewLine}";

        public static string BuildReturnOptionObjectDetail(SessionProperties sessionProperties) =>
            $"## ReturnOptionObject{Environment.NewLine}" +
            $"```{sessionProperties.ReturnOptionObject.ToJson()}```  {Environment.NewLine}";
    }
}
