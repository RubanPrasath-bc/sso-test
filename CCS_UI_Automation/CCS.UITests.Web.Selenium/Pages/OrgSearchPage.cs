using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class OrgSearchPage : BasePage
    {
        public OrgSearchPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement BtnRegister => Driver.GetClickableXPath("btnUserRegister");
        public IWebElement BtnStartNow => Driver.GetClickableXPath("btnStartNow");
        public IWebElement NumCompaniesHouse => Driver.GetClickableXPath("txtCompaniesHouse");
        public IWebElement BtnContinue => Driver.GetClickableXPath("btnContinue");
        public IWebElement TxtHeader => Driver.GetClickableXPath("txtHeader");

        public bool FinalHeaderAvailability()
        {
            return Driver.FindElement(By.XPath(Driver.GetElementPathFromCSV("txtHeader"))).Displayed.Equals(true);
        }
        public void searchorganisation()
        {
            Driver.Wait(2);
            //Click on the Register button
            BtnRegister.Click();
            //Click the Start Now button in next page
            BtnStartNow.Click();
            //Add a valid Companies House Number
            NumCompaniesHouse.SendKeys("11797697");
            //Click on the continue button
            BtnContinue.Click();
            Driver.Wait(3);


        }

    }
}
