using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestAdapterProblemProject
{
    public class Tests
    {
        public static IEnumerable<string> SourceProcess()
        {
            yield return Process.GetCurrentProcess().ProcessName;
        }
        [TestCaseSource(nameof(SourceProcess))]
        public void TestProcessName(string name)
        {
            Assert.Pass();
        }
    }
}