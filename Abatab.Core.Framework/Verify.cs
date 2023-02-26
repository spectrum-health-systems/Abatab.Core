// Abatab.Core.Framework.Verify.cs
// 230225.1749
// Copyright (c) A Pretty Cool Program

using System.Collections.Generic;
using System.IO;

namespace Abatab.Core.Framework
{
    public static class Verify
    {
        public static void DirectoriesExist(List<string> requiredDirectories)
        {
            foreach (string directory in requiredDirectories)
            {
                _=Directory.CreateDirectory(directory);
            }
        }


    }
}