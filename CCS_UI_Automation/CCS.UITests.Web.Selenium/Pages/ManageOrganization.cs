using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class ManageOrganization : BasePage
    {
        public ManageOrganization(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement CheckboxMicrosoft => Driver.GetClickableXPath("checkboxMicrosoft");
        public IWebElement CheckboxLinkedIn => Driver.GetClickableXPath("checkboxLinkedIn");
        public IWebElement BtnSaveChanges => Driver.GetClickableXPath("btnSaveChanges");
        public IWebElement LinkReturnToManageOrg => Driver.GetClickableXPath("linkReturnToManageOrg");
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
        public IWebElement BtnAddAnotherSite => Driver.GetClickableXPath("btnAddAnotherSite");
        public IWebElement TxtSiteName => Driver.GetClickableXPath("txtSiteName");
        public IWebElement TxtAddress => Driver.GetClickableXPath("txtAddress");
        public IWebElement TxtLocality => Driver.GetClickableXPath("txtLocality");
        public IWebElement TxtRegion => Driver.GetClickableXPath("txtRegion");
        public IWebElement TxtPostalCode => Driver.GetClickableXPath("txtPostalCode");
        public IWebElement TxtCountryCode => Driver.GetClickableXPath("txtCountryCode");
        public IWebElement LinkDeleteSite => Driver.GetClickableXPath("linkDeleteSite");


        public void changeorddetails()
        {
            Driver.WaitForLoader();
            
            //Click the Microsoft 365 check box
            CheckboxMicrosoft.Click();
            Driver.WaitForLoader();

            //Click the LinkedIn check box
            CheckboxLinkedIn.Click();
            Driver.WaitForLoader();

            //Click on the Save Changes button
            Driver.MoveToElement(BtnSaveChanges);
            BtnSaveChanges.Click();

        }

        public void AddContact()
        {
            Driver.WaitForLoader();
            
            //Click on the Add Another Contact button
            BtnAddAnotherContact.Click();
            Driver.WaitForLoader();

            //create select element object 
            var selectElement = new SelectElement(DropdownContactReason);
            // select an option in Contact Reason dropdown
            selectElement.SelectByText("SHIPPING");

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
            //Return to Manage your organization page
            LinkReturnToManageOrg.Click();
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
            //Return To Manage your organization page
            LinkReturnToManageOrg.Click();
            Driver.WaitForLoader();

            //Select the Edit link of an account
            LinkEditContact.Click();
            Driver.WaitForLoader();

            //Click the Delete contact link
            Driver.MoveToElement(LinkDeleteContact);

            //Click on the Delete Contact link
            LinkDeleteContact.Click();
            Driver.WaitForLoader();

            //Click the Confirm and Delete button in the confirmation page
            BtnConfirmAndDelete.Click();
            Driver.WaitForLoader();
        }

        public void AddSites()
        {
            Driver.WaitForLoader();
            //Click on the Add Another Site Button
            BtnAddAnotherSite.Click();
            Driver.WaitForLoader();

            //Add a site name
            TxtSiteName.SendKeys("Automation Site");

            //Add street address
            TxtAddress.SendKeys("Automation Street");

            //Add locality
            TxtLocality.SendKeys("Automation Locality");

            //Add a region
            TxtRegion.SendKeys("Automation Region");

            //Add a postal code
            TxtPostalCode.SendKeys("258014");

            //Add a country code
            TxtCountryCode.SendKeys("456");

            //Click on the Save Changes button
            BtnSaveChanges.Click();
            Driver.WaitForLoader();

        }

        public void EditSites()
        {
            Driver.WaitForLoader();

            //Select the Edit link of a site
            Driver.FindElements(By.XPath("//tbody/tr[1]/td[5]/a[1]"))[1].Click();
            Driver.WaitForLoader();

            //Clear and change the site name
            TxtSiteName.Clear();
            TxtSiteName.SendKeys("Automation Site1");

            //Clear and change the street address
            TxtAddress.Clear();
            TxtAddress.SendKeys("Automation Street1");

            //Add locality
            TxtLocality.Clear();
            TxtLocality.SendKeys("Automation Locality1");

            //Clear and change the region
            TxtRegion.Clear();
            TxtRegion.SendKeys("Automation Region1");

            //Clear and change the postal code
            TxtPostalCode.Clear();
            TxtPostalCode.SendKeys("2222");

            //Clear and change the country code
            TxtCountryCode.Clear();
            TxtCountryCode.SendKeys("444");

            //Click on the Save Changes button
            BtnSaveChanges.Click();
            Driver.WaitForLoader();

        }

        public void AddSiteContact()
        {
           
            Driver.WaitForLoader();

            //Select a edit icon of ant site
            Driver.FindElements(By.XPath("//tbody/tr[1]/td[5]/a[1]"))[1].Click();
            Driver.WaitForLoader();

            //Click on the Add Another Contact button
            BtnAddAnotherContact.Click();
            Driver.WaitForLoader();

            //create select element object 
            var selectElement = new SelectElement(DropdownContactReason);
            // select an option in Contact Reason dropdown
            selectElement.SelectByText("SHIPPING");

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

        public void EditSiteContact()
        {
            //Return to Edit Site page
            LinkReturnToManageOrg.Click();
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

        public void DeleteSiteContact()
        {
            //Return To Edit Site page
            LinkReturnToManageOrg.Click();
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

        public void DeleteSite()
        {
            Driver.WaitForLoader();

            //Select a edit icon of ant site
            Driver.FindElements(By.XPath("//tbody/tr[1]/td[5]/a[1]"))[1].Click();
            Driver.WaitForLoader();

            //Click the Delete contact link
            Driver.MoveToElement(LinkDeleteSite);
            LinkDeleteSite.Click();
            Driver.WaitForLoader();

            //Click the Confirm and Delete button in the confirmation page
            BtnConfirmAndDelete.Click();
            Driver.WaitForLoader();

        }

    }
}
