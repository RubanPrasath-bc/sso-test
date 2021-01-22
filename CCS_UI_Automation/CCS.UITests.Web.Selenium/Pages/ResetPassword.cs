using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;


namespace CCS.UITests.Web.Selenium.Pages
{
    public class ResetPassword : BasePage
    {
        public IWebElement LinkResetPassword => Driver.GetClickableXPath("linkResetPassword");
        public IWebElement BtnResetPassword => Driver.GetClickableXPath("btnResetPassword");
        public IWebElement TxtUserName => Driver.GetClickableXPath("txtUserName");
        public ResetPassword(IWebDriver driver) : base(driver)
        {
        }

        public void resetpassword()
        {
            TxtUserName.SendKeys("CCSTestUser1@yopmail.com");
            BtnResetPassword.Click();

        }
    }
}
