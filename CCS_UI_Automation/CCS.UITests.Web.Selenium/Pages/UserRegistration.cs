using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class UserRegistration : BasePage
    {
        public UserRegistration(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement BtnRegister => Driver.GetClickableXPath("btnRegister");
        public IWebElement BtnUserRegister => Driver.GetClickableXPath("btnUserRegister");
        public IWebElement TxtFirstName => Driver.GetClickableXPath("txtFirstName");
        public IWebElement TxtLastName => Driver.GetDisplayedXPath("txtLastName");
        public IWebElement TxtUserName => Driver.GetDisplayedXPath("txtUserName");
        public IWebElement TxtEmailAddress => Driver.GetDisplayedXPath("txtEmailAddress");

      
        public void RegisterUser()
        {

            TxtFirstName.SendKeys("CCSTestAutoUser");
            TxtLastName.SendKeys("AutoLastName");
            TxtUserName.SendKeys("CCSTestAutoUser4@yopmail.com");
            TxtEmailAddress.SendKeys("CCSTestAutoUser4@yopmail.com");
            BtnUserRegister.Click();


        }


    }
}
