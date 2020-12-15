using NUnit.Framework;

namespace CCS.UITests.Web.MainTests
{
    [TestFixture]
    public class BaseTest
    {
        public TestContext TestContext
        {
            get
            {
                return WebGlobal.TestContext;
            }
            set
            {
                WebGlobal.TestContext = value;
            }
        }
    }
}
