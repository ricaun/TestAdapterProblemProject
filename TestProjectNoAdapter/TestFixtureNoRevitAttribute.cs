#if NETFRAMEWORK

using NUnit.Framework;
using System;
using System.Linq;

namespace TestProjectNoAdapter
{
    [TestFixtureNoRevit]
    public class DummyTestToIgnoreRevitTest
    {
        [Test]
        public void Test()
        {
            Assert.Pass();
        }
    }

    public class TestFixtureNoRevitAttribute : TestFixtureAttribute
    {
        public TestFixtureNoRevitAttribute() : base()
        {
            if (AppDomain.CurrentDomain.GetAssemblies().Any(e => e.GetName().Name.Contains("RevitTest")))
                throw new NotSupportedException("This module should not be used by RevitTest.");
        }
    }
}

#endif
