﻿using System;
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
    public class ResetPasswordTest : BaseTest
    {
        [SetUp]
        //Open up the url and login to the system
       

        public void LoadSite()
        {
            WebGlobal.StartupURL();

        }


        //Verify the reset password UI functionalities
        [Test, Order(1)]
        public void VerifyResetPassword()
        {
            ResetPassword resetpassword = new ResetPassword(WebGlobal.NgDriver);
            resetpassword.LinkResetPassword.Click();
            resetpassword.resetpassword();


        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }

    }
}
