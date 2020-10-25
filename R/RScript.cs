using System;
using System.Diagnostics;
using System.IO;

namespace R
{
    public static class RScript
    {
        public static string RunRScript(string rpath, string scriptpath)
        {
            try
            {
                var info = new ProcessStartInfo
                {
                    FileName = rpath,
                    WorkingDirectory = Path.GetDirectoryName(scriptpath),
                    Arguments = scriptpath,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };

                using (var proc = new Process { StartInfo = info })
                {
                    proc.Start();
                    return proc.StandardOutput.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return string.Empty;
        }
    }
}
