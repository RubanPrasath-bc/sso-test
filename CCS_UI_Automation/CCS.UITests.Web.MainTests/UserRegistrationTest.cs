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
    public class UserRegistrationTest :BaseTest
    {

        [SetUp]

        public void LoadSite()
        {
            WebGlobal.StartupURL();

        }

        [Test, Order(1)]
        public void RegisterUser()
        {
            UserRegistration registeuser = new UserRegistration(WebGlobal.NgDriver);
            registeuser.BtnRegister.Click();
            registeuser.RegisterUser();
           
        }
    }
}
