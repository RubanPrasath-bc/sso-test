using System.Text;
using System.Threading.Tasks;
using CCS.UITests.Web.Selenium;
using CCS.UITests.Web.Selenium.Pages;
using NUnit.Framework;

namespace CCS.UITests.Web.MainTests
{
    [TestFixture, Order(1)]
    public class ManageServiceEligibilityTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            //Open up the url and login to the system
            WebGlobal.StartupPortal();

        }

        [Test, Order(1)]
        public void SearchOrg()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageServiceEligibility service = new ManageServiceEligibility(WebGlobal.NgDriver);

            //Click on the Manage Service Eligibility tile
            element.ElementManageServiceEligibility();

            //Assert that the navigated page name is Manage service eligibility
            Assert.IsTrue(basepage.HeaderAvailability("Manage service eligibility"));

            //Search for organization
            service.SearchOrg();
            
        }

        [Test, Order(1)]
        public void manageServiveEligibility()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageServiceEligibility service = new ManageServiceEligibility(WebGlobal.NgDriver);

            //Click on the Manage Service Eligibility tile
            element.ElementManageServiceEligibility();

            //Assert that the navigated page name is Manage service eligibility
            Assert.IsTrue(basepage.HeaderAvailability("Manage service eligibility"));

            //Search for an organization
            service.SearchOrg();

            //Search for organization
            service.manageserviceeligibility();

            //Assert that the navigated has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully saved the changes"));

        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }




    }




}
