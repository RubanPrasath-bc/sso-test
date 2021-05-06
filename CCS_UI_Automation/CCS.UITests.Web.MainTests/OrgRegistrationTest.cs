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
        public void RegisterBuyerOrganization()
        {

            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            OrgRegistration registration = new OrgRegistration(WebGlobal.NgDriver);

            //Add a Buyer organization
            registration.RegisterOrganizationBuyer();

            //Assert that the navigated has the success message
            Assert.IsTrue(basepage.HeaderAvailability("Confirm your email address"));


        }

        [Test, Order(1)]
        public void RegisterSupplierOrganization()
        {

            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            OrgRegistration registration = new OrgRegistration(WebGlobal.NgDriver);

            //Add a Supplier organization
            registration.RegisterOrganizationSupplier();

            //Assert that the navigated has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully nominated."));

        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }
    }
}
