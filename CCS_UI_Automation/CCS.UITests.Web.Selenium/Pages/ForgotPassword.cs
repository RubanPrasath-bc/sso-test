using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;


namespace CCS.UITests.Web.Selenium.Pages
{
    public class ForgotPassword : BasePage
    {
        public IWebElement LinkForgotPassword => Driver.GetClickableXPath("linkForgotPassword");
        public IWebElement BtnResetPassword => Driver.GetClickableXPath("btnResetPassword");
        public IWebElement TxtUserName => Driver.GetClickableXPath("txtUserName");
        public ForgotPassword(IWebDriver driver) : base(driver)
        {
        }

        public void ForgotPW()
        {
            //Click on the I have forgotten my password link
            LinkForgotPassword.Click();
            Driver.WaitForLoader();

            //Add a username 
            TxtUserName.SendKeys("automationuser88@yopmail.com");

            //Click on the Reset Password button
            BtnResetPassword.Click();

        }
    }
}
