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
        public IWebElement TileManageUsers => Driver.GetClickableXPath("tileManageUsers");
        public IWebElement TileManageOrganizations => Driver.GetClickableXPath("tileManageOrganizations");
        public IWebElement TileManageServiceEligibility => Driver.GetClickableXPath("tileManageServiceEligibility");

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

        public void ElementManageUsers()
        {
            //Click on the Manage Users tile
            Driver.WaitForLoader();
            TileManageUsers.Click();
            
        }

        public void ElementManageOrganizations()
        {
            //Click on the Manage Users tile
            Driver.WaitForLoader();
            TileManageOrganizations.Click();

        }

       public void ElementManageServiceEligibility()
        {
            //Click on the Manage Service Eligibility Tile
            Driver.WaitForLoader();
            TileManageServiceEligibility.Click();
        }





    }
}
