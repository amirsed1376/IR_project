using IR.UI.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace IR.UI.Common
{
    public static class ApplicationHelpers
    {
        public static Setting Settings = new Setting();
        public static bool FLGLoging = false;


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();


        public static void RunCommand(string cmd, params string [] args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Settings.PythonPath;
            start.Arguments = string.Format("{0} {1}", cmd, string.Join(" ",args));
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.WindowStyle = ProcessWindowStyle.Normal;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    process.WaitForExit();
                    Console.Write(result);
                }
            }
        }
        
        
        public static void RunCommand2(string cmd, params string [] args)
        {

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(Settings.PythonPath,cmd)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false
                //Arguments = string.Format("{0} {1}", cmd, string.Join(" ", args))
        };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);

            Console.ReadLine();
        }

        public static void runCmd(string cmdCommand)
        {
            String command = cmdCommand;
            ProcessStartInfo cmdsi = new ProcessStartInfo("python.exe");
            cmdsi.Arguments = command;
            Process cmd = Process.Start(cmdsi);
            cmd.WaitForExit();
        }


        public static void RunExeFile(params string [] args)
        {
            string filename = Path.Combine(Directory.GetCurrentDirectory(), "Exe","dist","main.exe");
            var proc = Process.Start(filename,string.Join(" ",args));

        }

    }
}
