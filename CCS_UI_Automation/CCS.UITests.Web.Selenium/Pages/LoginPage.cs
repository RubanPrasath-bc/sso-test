using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace CCS.UITests.Web.Selenium
{
    public class LoginPage : BasePage
    {

        //Page Objects
        private IWebElement TxtUserEmail => Driver.GetClickableXPath("txtLoginEmail");
        private IWebElement TxtPassword => Driver.GetClickableXPath("txtPassword");
        private IWebElement LoginButton => Driver.GetClickableXPath("btnLogin");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            
        }
        
        //Page Actions

        public Dashboard LoginUser(string username, string password)
        {
            //Login using username and password
            Driver.WaitForLoader();
            TxtUserEmail.SendKeys(username);
            TxtPassword.SendKeys(password);
            LoginButton.Click();
            //Ideally should return the navigating page object eg: Homepage. Change the return type of the method in that case.
            return new Dashboard(Driver);
        }

        //public void EnterSubscriptionKey(string subscriptionkey)
        //{
           
        //}
        
    }
    }
