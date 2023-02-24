// Abatab.Core.Catalog.SessionDetails.cs
// b230224.1700
// Copyright (c) A Pretty Cool Program

using System;

namespace Abatab.Core.Catalog
{
    public static class SessionDetails
    {
        public static string test(SessionProperties sessionProperties)
        {
            // TODO - This will be a combo of the header and the body
            return "";
        }

        public static string SessionDetailHeader(SessionProperties sessionProperties)
        {
            return Environment.NewLine +
                   $"==============={Environment.NewLine}" +
                   $"Session details{Environment.NewLine}" +
                   "================";
        }

        public static string SessionDetailBody(SessionProperties sessionProperties)
        {
            return Environment.NewLine +
                   $"Abatab version:               v23.2.0-development+230224.1346{Environment.NewLine}" +
                   $"Abatab mode:                  {sessionProperties.AbatabMode}{Environment.NewLine}" +
                   $"Abatab service root:          {sessionProperties.AbatabServiceRoot}{Environment.NewLine}" +
                   $"Abatab data root:             {sessionProperties.AbatabDataRoot}{Environment.NewLine}" +
                   $"Logging mode:                 {sessionProperties.LoggerMode}{Environment.NewLine}" +
                   $"Logging delay:                {sessionProperties.LoggerDelay}{Environment.NewLine}" +
                   $"Abatab fallback username:     {sessionProperties.AbatabFallbackUserName}{Environment.NewLine}" +
                   $"Debuggler mode:               {sessionProperties.DebugglerMode}{Environment.NewLine}" +
                   $"Session datestamp:            {sessionProperties.Datestamp}{Environment.NewLine}" +
                   $"Session timestamp:            {sessionProperties.Timestamp}{Environment.NewLine}" +
                   $"Script parameter:             {sessionProperties.ScriptParameter}{Environment.NewLine}" +
                   $"Request module:               {sessionProperties.RequestModule}{Environment.NewLine}" +
                   $"Request command:              {sessionProperties.RequestCommand}{Environment.NewLine}" +
                   $"Request action:               {sessionProperties.RequestAction}{Environment.NewLine}" +
                   $"Request option:               {sessionProperties.RequestOption}{Environment.NewLine}" +
                   $"Abatab username:              {sessionProperties.AbatabUserName}{Environment.NewLine}" +
                   $"Session data root:            {sessionProperties.SessionDataRoot}{Environment.NewLine}" +
                   $"Warning log directory:        {sessionProperties.WarningLogDirectory}{Environment.NewLine}" +
                   $"Public data root:             {sessionProperties.PublicDataRoot}{Environment.NewLine}" +
                   $"Public warning log directory: {sessionProperties.PublicWarningLogDirectory}{Environment.NewLine}" +
                   $"Debuggler log directory:      {sessionProperties.DebugglerLogDirectory}{Environment.NewLine}" +
                   Environment.NewLine;

            // TODO - Eventually re-introduce this stuff.
            //$"============================{Environment.NewLine}" +
            //$"Module details{Environment.NewLine}" +
            //$"============================" +
            //$"{BodyModuleDetail(abatabSession, "Date")}{Environment.NewLine}" +
            //$"{BodyModuleDetail(abatabSession, "QuickMedOrder")}{Environment.NewLine}" +
            //$"{BodyModuleDetail(abatabSession, "Prototype")}{Environment.NewLine}" +
            //$"{BodyModuleDetail(abatabSession, "Testing")}{Environment.NewLine}" +
            //Environment.NewLine +
            //$"===================={Environment.NewLine}" +
            //$"OptionObject details{Environment.NewLine}" +
            //$"====================" +
            //$"{BodyOptObjDetail(abatabSession.SentOptObj, "sentOptObj")}{Environment.NewLine}" +
            //$"{BodyOptObjDetail(abatabSession.WorkOptObj, "workerOptObj")}{Environment.NewLine}" +
            //$"{BodyOptObjDetail(abatabSession.FinalOptObj, "finalOptObj")}{Environment.NewLine}";
        }
    }
}