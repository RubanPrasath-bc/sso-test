using System.Text;
using System.Threading.Tasks;
using CCS.UITests.Web.Selenium;
using CCS.UITests.Web.Selenium.Pages;
using NUnit.Framework;


namespace CCS.UITests.Web.MainTests
{
    [TestFixture, Order(1)]
    public class ManageGroupsTest : BaseTest
    {

        [SetUp]
        public void Login()
        {
            //Open up the url and login to the system
            WebGlobal.StartupPortal();

        }

        [Test, Order(1)]

        public void ManageGroups()
        {

            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageGroups groups = new ManageGroups(WebGlobal.NgDriver);

            //Click on the Manage Groups tile
            element.ElementManageGroups();

            //Assert that the navigated page name is Manage Groups
            Assert.IsTrue(basepage.HeaderAvailability("Manage groups"));

            //Search for a group
            groups.SearchGroups();







        }
    }
}
