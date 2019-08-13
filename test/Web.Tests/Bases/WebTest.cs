using System.Diagnostics;
using Web.TestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Web.Tests
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
