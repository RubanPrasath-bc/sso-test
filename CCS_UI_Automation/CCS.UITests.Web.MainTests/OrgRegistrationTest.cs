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
    public class OrgRegistrationTest :BaseTest
    {

        [SetUp]

        public void LoadSite()
        {
            WebGlobal.RegistrationStartUP();

        }

        [Test, Order(1)]
        public void RegisterOrganization()
        {
            
           
        }
    }
}
