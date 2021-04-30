using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class ManageUsers : BasePage
    {

        public ManageUsers(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement TxtSearch => Driver.GetClickableXPath("txtSearch");
        public IWebElement BtnSearch => Driver.GetClickableXPath("btnSearch");
        public IWebElement ColumnHeaderEmail => Driver.GetClickableXPath("columnHeaderEmail");
        public IWebElement BtnAddUsers => Driver.GetClickableXPath("btnAddUsers");
        public IWebElement RadioBtnaddsingleuser => Driver.GetClickableXPath("radiobtnaddsingleuser");
        public IWebElement BtnContinue => Driver.GetClickableXPath("btnContinue");
        public IWebElement DrpdwnTitle => Driver.GetClickableXPath("drpdwnTitle");
        public IWebElement TxtFirstName => Driver.GetClickableXPath("txtFirstName");
        public IWebElement TxtLastName => Driver.GetClickableXPath("txtLastName");
        public IWebElement TxtEmail => Driver.GetClickableXPath("txtEmail");
        public IWebElement CheckboxOrganizationAdmin => Driver.GetClickableXPath("checkboxOrganizationAdmin");
        public IWebElement RadiobtnUsernameandPassword => Driver.GetClickableXPath("radiobtnUsernameandPassword");
        public IWebElement BtnSaveChanges => Driver.GetClickableXPath("btnSaveChanges");
        public IWebElement LinkEditUser => Driver.GetClickableXPath("linkEditUser");
        public IWebElement CheckboxOrganizationUserSupport => Driver.GetClickableXPath("checkboxOrganizationUserSupport");
        public IWebElement RadiobtnGoogle => Driver.GetClickableXPath("radiobtnGoogle");
        public IWebElement LinkReturnManageGroups => Driver.GetClickableXPath("linkReturnManageGroups");
        public IWebElement LinkDeleteUser => Driver.GetClickableXPath("linkDeleteUser");
        public IWebElement BtnConfirmandDelete => Driver.GetClickableXPath("btnConfirmandDelete");
        

        public void SearchUsers()
        {
            Driver.WaitForLoader();

            //Add search data to the search field
            TxtSearch.SendKeys("automation");

            //Click on the Search button
            BtnSearch.Click();

            //Move to the Search Results
            Driver.MoveToElement(ColumnHeaderEmail);

        }

        public void AddUsers()
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.GenerateRandomNumber(5, 100);

            Driver.WaitForLoader();

            //Click on the Add Users button
            BtnAddUsers.Click();

            //Select the Add Single User radio buttons
            RadioBtnaddsingleuser.Click();

            //Click on the Continue button
            BtnContinue.Click();
            Driver.WaitForLoader();

            //create select element object 
            var selectElement = new SelectElement(DrpdwnTitle);

            // select an option in Title dropdown
            selectElement.SelectByText("Mr");

            //Add a first name
            TxtFirstName.SendKeys("Automation");

            //Add a last name
            TxtLastName.SendKeys("User " + randomNumber);

            //Add an Email Address
            TxtEmail.SendKeys("automationuser" + randomNumber + "@yopmail.com");
            
            //Select the Organization Admin role
            CheckboxOrganizationAdmin.Click();

            //Select the Username and Password Sign-In provider
            RadiobtnUsernameandPassword.Click();

            //Click on the Save Changes button
            BtnSaveChanges.Click();
            Driver.WaitForLoader();

        }

        public void EditUser()
        {

            var generator = new RandomGenerator();
            var randomNumber = generator.GenerateRandomNumber(5, 100);

            Driver.WaitForLoader();

            LinkEditUser.Click();
            //create select element object 
            var selectElement = new SelectElement(DrpdwnTitle);

            // select an option in Title dropdown
            selectElement.SelectByText("Miss");

            //Add a first name
            TxtFirstName.Clear();
            TxtFirstName.SendKeys("Automation");

            //Add a last name
            TxtLastName.Clear();
            TxtLastName.SendKeys("User " + randomNumber);

            //Deselect the Organization Admin role
            CheckboxOrganizationAdmin.Click();

            //Select the Organization User Support role
            CheckboxOrganizationUserSupport.Click();

            //Change the Sign-In provider to Google
            RadiobtnGoogle.Click();

            //Click on the Save Chnages button
            BtnSaveChanges.Click();
            Driver.WaitForLoader();

        }

        public void DeleteUser()
        {

            Driver.WaitForLoader();

            //Click the Edit link of a user
            LinkEditUser.Click();

            //Click on the Delete User link
            LinkDeleteUser.Click();
            Driver.WaitForLoader();

            //Click the Confirm and Delete button
            BtnConfirmandDelete.Click();
            Driver.WaitForLoader();

        }

    }
}
