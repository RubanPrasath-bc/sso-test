using CCS.UITests.Web.Selenium.Helpers;
using OpenQA.Selenium;
using System;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class BasePage
    {
        public IWebDriver Driver { get; private set; }

        private BasePage()
        {
        }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement PageTitle => Driver.GetDisplayedXPath("pageTitle");

        //Common Objects

        public void UserLogout()
        {


        }

        public void GoToLogin()
        {
         
           
        }

    }
}
