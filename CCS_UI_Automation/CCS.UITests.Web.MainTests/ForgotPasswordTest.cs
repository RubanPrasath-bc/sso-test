using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCS.UITests.Web.Selenium;
using CCS.UITests.Web.Selenium.Pages;
using NUnit.Framework;

namespace CCS.UITests.Web.MainTests
{
    [TestFixture, Order(1)]
    public class ForgotPasswordTest : BaseTest
    {
        [SetUp]
        //Open up the url and login to the system
       

        public void LoadSite()
        {
            WebGlobal.StartupURL();

        }


        //Verify the forgot password UI functionalities
        [Test, Order(1)]
        public void VerifyResetPassword()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            ForgotPassword resetpassword = new ForgotPassword(WebGlobal.NgDriver);

            //Send a forget password email
            resetpassword.ForgotPW();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("The reset password email has been successfully sent"));

        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }

    }
}
