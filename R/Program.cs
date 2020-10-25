using System;

namespace R
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var rpath = "/usr/bin/Rscript";
            var scriptpath = "/home/alvydas/Projects/R/framefrq.R cdsfrq.dat ncdsfrq.dat";
            var output = RScript.RunRScript(rpath, scriptpath);

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
