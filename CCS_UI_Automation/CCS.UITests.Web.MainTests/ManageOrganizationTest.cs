using System.Text;
using System.Threading.Tasks;
using CCS.UITests.Web.Selenium;
using CCS.UITests.Web.Selenium.Pages;
using NUnit.Framework;

namespace CCS.UITests.Web.MainTests
{
    [TestFixture, Order(1)]
    public class ManageOrganizationTest : BaseTest
    {

        [SetUp]
        public void Login()
        {
            //Open up the url and login to the system
            WebGlobal.StartupPortal();

        }

        [Test, Order(1)]

        public void ManageOrganizations()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageOrganization organization = new ManageOrganization(WebGlobal.NgDriver);

            //Click on the Manage organisation(s) tile
            element.ElementManageOrganizations();

            //Assert that the navigated page name is Manage your organisation
            Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

            //Change organizatio's sign-in providers
            organization.changeorddetails();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("Your changes have been saved"));

        }

        [Test, Order(2)]
        public void ManageOrgContact()

        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageOrganization organization = new ManageOrganization(WebGlobal.NgDriver);

            //Click on the Manage organisation(s) tile
            element.ElementManageOrganizations();

            //Assert that the navigated page name is Manage your organisation
            Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

            //Add a new contact to the organization
            organization.AddContact();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully added an organisation contact details"));

            //Edit the contacts
            organization.EditContact();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully updated the organisation contact details"));

            //Delet contact
            organization.DeleteContact();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully deleted the contact details"));

        }

        [Test, Order(2)]

        public void ManageOrgSites()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageOrganization organization = new ManageOrganization(WebGlobal.NgDriver);

            //Click on the Manage organisation(s) tile
            element.ElementManageOrganizations();

            //Add a new site
            organization.AddSites();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully added a site"));

        }

        [Test, Order(2)]
        public void EditSite()

            {
                BasePage basepage = new BasePage(WebGlobal.NgDriver);
                Dashboard element = new Dashboard(WebGlobal.NgDriver);
                ManageOrganization organization = new ManageOrganization(WebGlobal.NgDriver);

                //Click on the Manage organisation(s) tile
                element.ElementManageOrganizations();

                //Assert that the navigated page name is Manage your organisation
                Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

                //Edit a site
                organization.EditSites();

                //Assert that the navigated page has the success message
                Assert.IsTrue(basepage.HeaderAvailability("You have successfully update the site"));

            }

        [Test, Order(2)]

        public void ManageSiteContact()

        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageOrganization organization = new ManageOrganization(WebGlobal.NgDriver);

            //Click on the Manage organisation(s) tile
            element.ElementManageOrganizations();

            //Assert that the navigated page name is Manage your organisation
            Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

            //Add a contact for site
            organization.AddSiteContact();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully added a site contact details"));

            //Edit site contacts
            organization.EditSiteContact();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully updated the site contact details"));

            //Delete site contact
            organization.DeleteSiteContact();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully deleted the contact details"));

        }

        [Test, Order(2)]
        public void DeleteSite()
        {
            BasePage basepage = new BasePage(WebGlobal.NgDriver);
            Dashboard element = new Dashboard(WebGlobal.NgDriver);
            ManageOrganization organization = new ManageOrganization(WebGlobal.NgDriver);

            //Click on the Manage organisation(s) tile
            element.ElementManageOrganizations();

            //Assert that the navigated page name is Manage your organisation
            Assert.IsTrue(basepage.HeaderAvailability("Manage your organisation"));

            //Delete a site
            organization.DeleteSite();

            //Assert that the navigated page has the success message
            Assert.IsTrue(basepage.HeaderAvailability("You have successfully delete the site"));


        }

        [TearDown]
        public void TearDown()
        {
            WebGlobal.Cleanup();
        }


    }
}
