using System.Text;
using System.Threading.Tasks;
using CCS.UITests.Web.Selenium;
using CCS.UITests.Web.Selenium.Pages;
using NUnit.Framework;
namespace CCS.UITests.Web.MainTests

{
    [TestFixture, Order(1)]
    public class ManageMyAccountTest : BaseTest
    {

        [SetUp]

        
        public void Login()
        {
            //Open up the url and login to the system
            WebGlobal.StartupPortal();

        }

        [Test, Order(1)]

        public void ManageMyAccount()
        {

            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);

            //Select the Manage My Account widget
            element.ElementManageMyAccount();

            //Assert that the navigated page name is Manage my Account
            Assert.IsTrue(basepage.HeaderAvailability("Manage my account"));

            //Change the account details and save them
            ManageMyAccount manageaccount = new ManageMyAccount(WebGlobal.NgDriver);
            manageaccount.ChangeAccountDetails();

            //Assert that the changes are successfully saved by the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully saved these changes"));
         
        }

        [Test, Order(2)]
        public void ManageMyContact()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);

            //Select the Manage My Account widget
            element.ElementManageMyAccount();

            //Assert that the navigated page name is Manage my Account
            Assert.IsTrue(basepage.HeaderAvailability("Manage my account"));

            //Add a new contact
            ManageMyAccount manageaccount = new ManageMyAccount(WebGlobal.NgDriver);
            manageaccount.AddContact();

            //Assert that the contacts are successfully added by the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have updated your contact list"));

            //Edit the added contacts
            manageaccount.EditContact();

            //Assert that the contacts are successfully updated by the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have updated your contact list"));

            //Delete the contact
            manageaccount.DeleteContact();

            //Assert that the contact is successfully deleted by the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully deleted contact details"));

        }

        //[TearDown]
        //public void TearDown()
        //{
        //    WebGlobal.Cleanup();
        //}
    }
}
