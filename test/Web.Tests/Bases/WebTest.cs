using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.TestFramework.Bases;

namespace Web.Tests.Bases
{
    public class WebTest : BaseTest
    {
        [AssemblyInitialize]
        public static new void AssemblyInitialize(TestContext context)
        {
            BaseTest.AssemblyInitialize(context);
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            Trace.TraceInformation("Start {0}", this.TestContext.TestName);
        }

        [TestCleanup]
        public override void TestCleanup()
        {
            Trace.TraceInformation("End {0}", this.TestContext.TestName);
            base.TestCleanup();
        }

        [AssemblyCleanup]
        public static new void AssemblyCleanup()
        {
            BaseTest.AssemblyCleanup();
        }
    }
}
