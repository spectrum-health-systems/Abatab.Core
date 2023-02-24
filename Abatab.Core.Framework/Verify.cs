using System.Collections.Generic;
using System.IO;

namespace Abatab.Core.Framework
{
    public class Verify
    {
        public static void RequiredDirectories(List<string> requiredDirectories)
        {
            foreach (string directory in requiredDirectories)
            {
                _=Directory.CreateDirectory(directory);
            }
        }
    }
}