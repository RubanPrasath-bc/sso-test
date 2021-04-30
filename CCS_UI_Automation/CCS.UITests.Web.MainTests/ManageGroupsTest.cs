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

            //Add a group name
            groups.AddGroupName();

            //Assert that the navigated page name is Add users
            Assert.IsTrue(basepage.HeaderAvailability("Add users"));

            //Add users to the group
            groups.AddUsersToGroup();

            //Assert that the navigated page name is Add roles
            Assert.IsTrue(basepage.HeaderAvailability("Add roles"));

            //Add roles to the group
            groups.AddRolesToGroup();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("Group created successfully with"));

        }

        [Test, Order(2)]
        public void EditandDeleteGroups()
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

            //Change Group name
            groups.EditGroupName();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully updated the the group name"));

            //Change Group Roles
            groups.EditGroupRoles();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully updated the roles of the group"));

            //Change the Group Users
            groups.EditGroupUsers();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully updated the users of the group"));

            //Delete User
            groups.DeleteGroup();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully deleted this group"));

        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }


    }
}
