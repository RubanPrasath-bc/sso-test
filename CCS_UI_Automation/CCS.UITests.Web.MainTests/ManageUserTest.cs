using System.Text;
using System.Threading.Tasks;
using CCS.UITests.Web.Selenium;
using CCS.UITests.Web.Selenium.Pages;
using NUnit.Framework;

namespace CCS.UITests.Web.MainTests
{
    [TestFixture, Order(1)]
    public class ManageUserTest : BaseTest
    {
        [SetUp]
        public void Login()
        {
            //Open up the url and login to the system
            WebGlobal.StartupPortal();

        }

        [Test, Order(1)]
        public void ManageUsers()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageUsers users = new ManageUsers(WebGlobal.NgDriver);

            element.ElementManageUsers();

            //Assert that the navigated page name is Manage Users
            Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

            //Search for users
            users.SearchUsers();

            //Add a new user
            users.AddUsers();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("will be emailed instructions on how to setup their password"));

        }

        [Test, Order(2)]

        public void EditUser()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageUsers users = new ManageUsers(WebGlobal.NgDriver);

            element.ElementManageUsers();

            //Assert that the navigated page name is Manage Users
            Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

            //Search for a user
            users.SearchUsers();

            //Edit the user
            users.EditUser();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully saved these changes"));
           

        }

        [Test, Order(3)]
        public void DeleteUser()

        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageUsers users = new ManageUsers(WebGlobal.NgDriver);

            element.ElementManageUsers();

            //Assert that the navigated page name is Manage Users
            Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

            //Search the user
            users.SearchUsers();

            //Delete the user
            users.DeleteUser();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully deleted the user account"));


        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }
    }
}
