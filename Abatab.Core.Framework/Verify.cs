// Abatab.Core.Framework.Verify.cs
// b---------x
// Copyright (c) A Pretty Cool Program

using System.Collections.Generic;
using System.IO;

namespace Abatab.Core.Framework
{
    /// <summary>Summary goes here.</summary>
    public static class Verify
    {
        /// <summary>Summary goes here.</summary>
        public static void DirectoriesExist(List<string> requiredDirectories)
        {
            foreach (string directory in requiredDirectories)
            {
                _=Directory.CreateDirectory(directory);
            }
        }


    }
}