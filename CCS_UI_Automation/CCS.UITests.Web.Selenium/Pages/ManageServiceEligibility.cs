using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class ManageServiceEligibility : BasePage
    {
        public ManageServiceEligibility(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement TxtSearch => Driver.GetClickableXPath("txtSearch");
        public IWebElement BtnSearch => Driver.GetClickableXPath("btnSearch");
        public IWebElement RadioButtonBrickendon => Driver.GetClickableXPath("radioButtonBrickendon");
        public IWebElement BtnContinue => Driver.GetClickableXPath("btnContinue");
        public IWebElement RadiobuttonYes => Driver.GetClickableXPath("radiobuttonYes");
        public IWebElement CheckboxOrganizationUserSupport => Driver.GetClickableXPath("checkboxOrganizationUserSupport");
        public IWebElement CheckboxRMIUser => Driver.GetClickableXPath("checkboxRMIUser");
        public IWebElement BtnSubmit => Driver.GetClickableXPath("btnSubmit");


        public void SearchOrg()
        {
            Driver.WaitForLoader();

            //Add a test to the search field
            TxtSearch.SendKeys("Brickendon");

            //Click on the Search button
            BtnSearch.Click();

            //Select the search result
            RadioButtonBrickendon.Click();
        }

        public void manageserviceeligibility()

        {
            //Select the Brickendon organization
            RadioButtonBrickendon.Click();

            //Click on the continue button
            BtnContinue.Click();

            Driver.WaitForLoader();

            //Click on the continue button in the next page
            BtnContinue.Click();

            Driver.WaitForLoader();

            //Select the Radio button Yes
            RadiobuttonYes.Click();

            Driver.WaitForLoader();

            //Select the Organization User Support check box
            //Driver.MoveToElement(CheckboxOrganizationUserSupport);
            CheckboxOrganizationUserSupport.Click();

            Driver.WaitForLoader();

            //Select the RMI User role
            CheckboxRMIUser.Click();

            Driver.WaitForLoader();

            //Click on the Continue button
            BtnContinue.Click();

            Driver.WaitForLoader();

            //Click submit button
            BtnSubmit.Click();

        }

        
    }
}
