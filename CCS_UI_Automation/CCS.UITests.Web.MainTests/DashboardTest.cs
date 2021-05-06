using CCS.UITests.Web.Selenium.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCS.UITests.Web.MainTests
{
    [TestFixture, Order(1)]
    public class DashboardTest : BaseTest
    {

        [SetUp]
        //Open up the url in browser and login to the system
        public void Login()
        {
            WebGlobal.StartupPortal();

        }


        //Verify the Dashboard page UI functionalities
        [Test, Order(1)]
        public void VerifyManageMyAccount()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);

            //Click on the Manage My account dashboard tile
            element.ElementManageMyAccount();

            //Assert that the navigated page name is Manage my Account
            Assert.IsTrue(basepage.HeaderAvailability("Manage my account"));
        }

        [Test, Order(1)]
        public void VerifyManageGroups()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);

            //Click on the Manage Groups dashboard tile
            element.ElementManageGroups();

            //Assert that the navigated page name is Manage Groups
            Assert.IsTrue(basepage.HeaderAvailability("Manage groups"));
        }

        [Test, Order(1)]
        public void VerifyManageUsers()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);

            //Click on the Manage Users dashboard tile
            element.ElementManageUsers();

            //Assert that the navigated page name is Manage Users
            Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

        }

        [Test, Order(1)]
        public void VerifyManageOrganiations()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);

            //Click on the Manage organisation(s) tile
            element.ElementManageOrganizations();

            //Assert that the navigated page name is Manage your organisation
            Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

        }

        [Test, Order(1)]
        public void VerifyManageServiceEligibility()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);

            //Click on the Manage Service Eligibility tile
            element.ElementManageServiceEligibility();

            //Assert that the navigated page name is Manage service eligibility
            Assert.IsTrue(basepage.HeaderAvailability("Manage service eligibility"));

        }

        [Test, Order(1)]
        public void VerifyManageOrgUserSupport()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);

            //Click on the Organization User Support tile
            element.ElementOrgUserSupport();

            //Assert that the navigated page name is Organisation user support
            Assert.IsTrue(basepage.HeaderAvailability("Organisation user support"));

        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }

    }
}
