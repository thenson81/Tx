using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppSdkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo schema = new FileInfo(@"C:\Rms\1109\BothLogs\schema2.man");
            var manifest = File.ReadAllText(schema.FullName);
            var manifestDictionary = Tx.Windows.ManifestParser.Parse(manifest);
            Dictionary<string, string> generated = new Dictionary<string, string>();
        }
    }
}
