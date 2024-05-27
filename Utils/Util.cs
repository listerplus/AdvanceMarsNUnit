using System;

namespace AdvanceMarsNUnit.Utils
{
    public class Util
    {
        public static string GetProjRootDir()
        {
            string currentDir = Directory.GetCurrentDirectory();
            return currentDir.Split("bin")[0];
        }
    }
}
