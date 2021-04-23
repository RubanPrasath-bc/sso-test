using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class ManageMyAccount : BasePage
    {

        public ManageMyAccount(IWebDriver driver) : base(driver)
        {
        }

        
        public IWebElement Txtfirstname => Driver.GetClickableXPath("txtFirstName");
        public IWebElement Txtlastname => Driver.GetClickableXPath("txtLastName");
        public IWebElement BtnSaveChanges => Driver.GetClickableXPath("btnSaveChanges");
        public IWebElement LinkReturnManageAccount => Driver.GetClickableXPath("linkReturnManageAccount");
        public IWebElement BtnAddAnotherContact => Driver.GetClickableXPath("btnAddAnotherContact");
        public IWebElement DropdownContactReason => Driver.GetClickableXPath("dropdownContactReason");
        public IWebElement TxtContactName => Driver.GetClickableXPath("txtContactName");
        public IWebElement TxtEmail => Driver.GetClickableXPath("txtEmail");
        public IWebElement TxtPhone => Driver.GetClickableXPath("txtPhone");
        public IWebElement TxtFax => Driver.GetClickableXPath("txtFax");
        public IWebElement TxtWebAddress => Driver.GetClickableXPath("txtWebAddress");
        public IWebElement LinkEditContact => Driver.GetClickableXPath("linkEditContact");
        public IWebElement LinkDeleteContact => Driver.GetClickableXPath("linkDeleteContact");
        public IWebElement BtnConfirmAndDelete => Driver.GetClickableXPath("btnConfirmandDelete");


        public void ChangeAccountDetails()
        {
            Driver.WaitForLoader();

            //Clear the details in firstname field and add a new name
            Txtfirstname.Clear();
            Txtfirstname.SendKeys("TestAutoFirst");

            //Clear the details in lastname field and add a new name
            Txtlastname.Clear();
            Txtlastname.SendKeys("TestAutoLast");

            //Scroll to bottom 
            Driver.ScrollToDown();

            //Click the Save Changes button
            BtnSaveChanges.Click();
            Driver.WaitForLoader();
        }

        public void AddContact()
        {
           
            Driver.WaitForLoader();

            //Go to Add Another Contact Button
            Driver.MoveToElement(BtnAddAnotherContact);

            //Click on the Add Another Contact button
            BtnAddAnotherContact.Click();
            Driver.WaitForLoader();
       
            //create select element object 
            var selectElement = new SelectElement(DropdownContactReason);
            // select an option in Contact Reason dropdown
            selectElement.SelectByText("BILLING");

            //Add a Contact name
            TxtContactName.SendKeys("AutoTestName");

            //Add an email
            TxtEmail.SendKeys("AutoTestEmail@yopmail.com");

            //Add a phone number
            TxtPhone.SendKeys("+4523536377");

            //Add a Fax number
            TxtFax.SendKeys("563217363");

            //Add a web address
            TxtWebAddress.SendKeys("www.autotest.com");

            //Click on the Save Changes button
            BtnSaveChanges.Click();
            Driver.WaitForLoader();

        }

        public void EditContact()
        {
            //Return to Manage My Account page
            LinkReturnManageAccount.Click();
            Driver.WaitForLoader();

            //Click on the edit link of the firt contact
            LinkEditContact.Click();
            Driver.WaitForLoader();

            //create select element object 
            var selectElement = new SelectElement(DropdownContactReason);
            // select an option in Contact Reason dropdown
            selectElement.SelectByText("SHIPPING");

            //Clear and add a new Contact name
            TxtContactName.Clear();
            TxtContactName.SendKeys("AutoTestName1");

            //Clear and add a new email
            TxtEmail.Clear();
            TxtEmail.SendKeys("AutoTestEmail1@yopmail.com");

            //Clear and add a new phone number
            TxtPhone.Clear();
            TxtPhone.SendKeys("+452353637767");

            //Clear and add a new Fax number
            TxtFax.Clear();
            TxtFax.SendKeys("56321736311");

            //Clear and add a new web address
            TxtWebAddress.Clear();
            TxtWebAddress.SendKeys("www.autotest1.com");

            //Click on the Save Changes button
            BtnSaveChanges.Click();
            Driver.WaitForLoader();

        }

        public void DeleteContact()
        {
            //Return To Manage My Account Page
            LinkReturnManageAccount.Click();
            Driver.WaitForLoader();

            //Select the Edit link of an account
            LinkEditContact.Click();
            Driver.WaitForLoader();

            //Click the Delete contact link
            Driver.MoveToElement(LinkDeleteContact);
            LinkDeleteContact.Click();
            Driver.WaitForLoader();

            //Click the Confirm and Delete button in the confirmation page
            BtnConfirmAndDelete.Click();
            Driver.WaitForLoader();



        }

    }
}
