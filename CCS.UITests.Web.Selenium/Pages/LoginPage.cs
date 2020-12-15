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


        public LoginPage(IWebDriver driver) : base(driver)
        {
            
        }
        
        //Page Actions

        public Dashboard LoginUser(string username, string password)
        {            
            return new Dashboard(Driver);
        }

        public void EnterSubscriptionKey(string subscriptionkey)
        {
           
        }
        
    }
    }
