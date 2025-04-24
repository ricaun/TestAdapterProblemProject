using NUnit.Framework;
using System.Diagnostics;

namespace TestAdapterProblemProject
{
    public class SampleTests
    {
        [Test]
        public void SampleTest()
        {
            System.Console.WriteLine(Process.GetCurrentProcess().ProcessName);
            Assert.Pass();
        }

        [TestCase(1)]
        [TestCase(2)]
        public void SampleTestCase(int value)
        {
            Assert.Pass();
        }
    }
}


