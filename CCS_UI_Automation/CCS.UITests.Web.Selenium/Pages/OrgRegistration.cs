using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class OrgRegistration : BasePage
    {
        public OrgRegistration(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement BtnStartNow => Driver.GetClickableXPath("btnStartNow");
        public IWebElement RadiobtnBuyer => Driver.GetClickableXPath("radiobtnBuyer");
        public IWebElement BtnContinue => Driver.GetClickableXPath("btnContinue");
        public IWebElement TxtCompanyHouse => Driver.GetDisplayedXPath("txtCompanyHouse");
        public IWebElement TxtFirstname1 => Driver.GetDisplayedXPath("txtFirstname1");
        public IWebElement TxtLastname1 => Driver.GetDisplayedXPath("txtLastname1");
        public IWebElement TxtEmail => Driver.GetDisplayedXPath("txtEmail");
        public IWebElement LabelDandB => Driver.GetDisplayedXPath("labelDandB");
        public IWebElement TxtDandB => Driver.GetDisplayedXPath("txtDandB");
        public IWebElement LinkNominate => Driver.GetDisplayedXPath("linkNominate");



        public void RegisterOrganizationBuyer()
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.GenerateRandomNumber(5, 100);

            //Click on the Start Now button
            BtnStartNow.Click();

            //Select the Buyer radio button
            RadiobtnBuyer.Click();

            //Click the Continue button
            BtnContinue.Click();

            //Click Continue button in the Buyer type page
            BtnContinue.Click();

            //Click Continue button in the Register Your Organization page
            BtnContinue.Click();

            //Search for a organization id
            TxtCompanyHouse.SendKeys("02970406");

            //Click Continue button in the Enter Organization Detail page
            BtnContinue.Click();
            Driver.WaitForLoader();

            //Click Continue button in the Confirm Organization Detail page
            BtnContinue.Click();

            //Enter Admin's first name
            TxtFirstname1.SendKeys("Automation");

            //Enter Admin's last name
            TxtLastname1.SendKeys("User");

            //Enter the Email Address
            TxtEmail.SendKeys("automationuser" + randomNumber + "@yopmail.com");

            //Click Continue button in the administrator account details page
            BtnContinue.Click();
            Driver.WaitForLoader();
        }

        public void RegisterOrganizationSupplier()
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.GenerateRandomNumber(5, 100);

            //Click on the Start Now button
            BtnStartNow.Click();

            //Click the Continue button
            BtnContinue.Click();

            //Click Continue button in the Register Your Organization page
            BtnContinue.Click();

            //Select the Dun & Bradstreet radio button
            LabelDandB.Click();

            //Enter an organization id
            TxtDandB.SendKeys("224404980");

            //Click Continue button in the Enter Organization Detail page
            BtnContinue.Click();

            //Click Continue button in the Confirm Organization Detail page
            BtnContinue.Click();

            //Click Continue button in the Confirm Additional Registry page
            BtnContinue.Click();

            //Click on the 'nominate a colleague to register and become an administrator' link
            LinkNominate.Click();

            //Enter nominated admin's first name
            TxtFirstname1.SendKeys("Automation");

            //Enter last name
            TxtLastname1.SendKeys("User");

            //Enter the Email Address
            TxtEmail.SendKeys("automationuser" + randomNumber + "@yopmail.com");

            //Click Continue button in the administrator account details page
            BtnContinue.Click();
            Driver.WaitForLoader();

        }

    }
}
