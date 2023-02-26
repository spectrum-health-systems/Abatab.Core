// Abatab.Core.Utilities.PrimevalLog.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System;
using System.IO;

namespace Abatab.Core.Utilities
{
    public class PrimevalLog
    {
        public static void WriteLocal(string fileExtension)
        {
            _=File.Create($@"C:\AbatabData\Primeval\{DateTime.Now:HHmmss_fffffff}_Abatab.{fileExtension}");
        }
    }
}