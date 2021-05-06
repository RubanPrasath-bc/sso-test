using System.Text;
using System.Threading.Tasks;
using CCS.UITests.Web.Selenium;
using CCS.UITests.Web.Selenium.Pages;
using NUnit.Framework;


namespace CCS.UITests.Web.MainTests
{
    [TestFixture, Order(1)]
    public class OrgUserSupportTest : BaseTest
    {

        [SetUp]
        public void Login()
        {
            //Open up the url and login to the system
            WebGlobal.StartupPortal();

        }

        [Test, Order(1)]
        public void SearchUser()
        {

            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            OrgUserSupport support = new OrgUserSupport(WebGlobal.NgDriver);

            //Click on the Organization User Support tile
            element.ElementOrgUserSupport();

            //Assert that the navigated page name is Organisation user support
            Assert.IsTrue(basepage.HeaderAvailability("Organisation user support"));

            //Search for a organization user
            support.SearchOrganization();
        }

        [Test, Order(1)]
        public void OrgAdminRole()
        {

            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            OrgUserSupport support = new OrgUserSupport(WebGlobal.NgDriver);

            //Click on the Organization User Support tile
            element.ElementOrgUserSupport();

            //Assert that the navigated page name is Organisation user support
            Assert.IsTrue(basepage.HeaderAvailability("Organisation user support"));

            //Assign or Unassign the Adminstration role
            support.ManageOrgAdminRole();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully changed the organisation administrator"));

        }

        [Test, Order(1)]
        public void ResetUserPW()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            OrgUserSupport support = new OrgUserSupport(WebGlobal.NgDriver);

            //Click on the Organization User Support tile
            element.ElementOrgUserSupport();

            //Assert that the navigated page name is Organisation user support
            Assert.IsTrue(basepage.HeaderAvailability("Organisation user support"));

            //Send reset password email to user
            support.UserResetPW();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("A reset email has been sent to"));

        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }
    }
}
