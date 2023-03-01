// Abatab.Core.Utilities.PrimevalLog.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System;
using System.IO;

namespace Abatab.Core.Utilities
{
    /// <summary>Summary goes here.</summary>
    public static class PrimevalLog
    {
        /// <summary>Summary goes here.</summary>
        public static void WriteLocal(string fileExtension)
        {
            _=File.Create($@"C:\AbatabData\Primeval\{DateTime.Now:HHmmss_fffffff}_Abatab.{fileExtension}");
        }
    }
}