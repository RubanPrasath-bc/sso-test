using CCS.UITests.Web.Selenium;
using NUnit.Framework;

namespace CCS.UITests.Web.MainTests
{

    [TestFixture , Order(1)]
    public class LoginTest : BaseTest
    {
        [SetUp]

        public void Login()
        {
            WebGlobal.StartupPortal();
           
        }


      
        [Test, Order(1)]
        public void VerifyLoginUserCode()
        {


        }

        [Test, Order(2)]
        public void VerifyEnterSubscriptionForNewUser()
        { 

        }


        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }
    }
}
