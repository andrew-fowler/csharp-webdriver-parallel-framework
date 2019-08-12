using System.Diagnostics;
using Web.TestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
namespace Web.Tests
{
    public class BaseTest : WebTest
    {
        [AssemblyInitialize]
        public static new void AssemblyInitialize(TestContext context)
        {
            WebTest.AssemblyInitialize(context);
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
            WebTest.AssemblyCleanup();
        }
    }
}
