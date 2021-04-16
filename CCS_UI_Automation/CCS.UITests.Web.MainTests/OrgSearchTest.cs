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
    public class OrgSearchTest : BaseTest
    {
        [SetUp]
        //Open up the url and login to the system


        public void LoadSite()
        {
            WebGlobal.StartupURL();

        }

        [Test, Order(1)]

        public void searchorganisation()
        {
            OrgSearchPage searchorg = new OrgSearchPage(WebGlobal.NgDriver);
            searchorg.searchorganisation();
            //Assert that the Organization already registered message is giving in the page
            Assert.IsTrue(searchorg.FinalHeaderAvailability(), "Organization does not exist");

        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }

    }
}
