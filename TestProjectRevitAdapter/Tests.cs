using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestProjectRevitAdapter
{
    public class Tests
    {
        public static IEnumerable<string> SourceProcess()
        {
            var processName = Process.GetCurrentProcess().ProcessName;
            if (processName.Contains("Revit")) processName = "Revit";
            yield return processName;
        }
        [TestCaseSource(nameof(SourceProcess))]
        public void TestProcessName(string name)
        {
            Assert.Pass();
        }
    }
}