using IR.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IR.UI.Common
{
    public static class ApplicationHelpers
    {
        public static Setting Settings = new Setting();
        public static bool FLGLoging = false;

        public static void RunCommand(string cmd, params string [] args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Settings.PythonPath;
            start.Arguments = string.Format("{0} {1}", cmd, string.Join(" ",args));
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }

    }
}
