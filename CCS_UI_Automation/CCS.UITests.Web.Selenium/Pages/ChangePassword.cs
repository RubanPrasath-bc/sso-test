using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class ChangePassword : BasePage

    {
        public IWebElement LinkChangePassword => Driver.GetClickableXPath("linkChangePassword");
        public IWebElement TxtPassword => Driver.GetClickableXPath("txtPassword");
        public IWebElement TxtUserName => Driver.GetClickableXPath("txtUserName");
        public IWebElement BtnChangePassword => Driver.GetClickableXPath("btnChangePassword");
        public ChangePassword(IWebDriver driver) : base(driver)
        {
        }

        public void changepassword()
        {
           
            TxtUserName.SendKeys("kawshi1@yopmail.com");

            RandomGenerator generateNumber = new RandomGenerator();
            int randomNumber = generateNumber.GenerateRandomNumber(1000, 10000);
            var AutoPassword = $"CCSAuto@_{randomNumber}";
            TxtPassword.SendKeys(AutoPassword);

            BtnChangePassword.Click();


        }
    }
}
