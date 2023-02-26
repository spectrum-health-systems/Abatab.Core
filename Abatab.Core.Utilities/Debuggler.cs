﻿// Abatab.Core.Utilities.Debuggler.cs
// b230225.1749
// Copyright (c) A Pretty Cool Program

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Abatab.Core.Utilities
{
    public static class Debuggler
    {
        public static void WriteLocal(string exeAssembly, string logMsg = "", [CallerFilePath] string callPath = "", [CallerMemberName] string callMember = "", [CallerLineNumber] int callLine = 0)
        {
            Thread.Sleep(100);
            File.WriteAllText($@"C:\AbatabData\Debuggler\{DateTime.Now:HHmmss_fffffff}-{exeAssembly}-{Path.GetFileName(callPath)}-{callMember}-{callLine}.debuggler", logMsg);
        }
    }
}