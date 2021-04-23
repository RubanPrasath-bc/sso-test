using CCS.UITests.Web.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class Dashboard : BasePage
    {

        public Dashboard(IWebDriver driver) : base(driver)
        {
           
        }

        public IWebElement TileManageMyAccount => Driver.GetClickableXPath("tileManageMyAccount");
        public IWebElement TileManageGroups => Driver.GetClickableXPath("tileManageGroups");

        public void ElementManageMyAccount()
        {
            //Click on the Manage My Account tile
            Driver.WaitForLoader();
            TileManageMyAccount.Click();
        }

        public void ElementManageGroups()
        {
            //Click on the Manage Group(s) tile
            Driver.WaitForLoader();
            TileManageGroups.Click();
        }





    }
}
