using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class ManageGroups : BasePage
    {
        public ManageGroups(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement TxtSearch => Driver.GetClickableXPath("txtSearch");
        public IWebElement BtnSearch => Driver.GetClickableXPath("btnSearch");
        public IWebElement ColumnHeader => Driver.GetClickableXPath("columnHeader");

        public void SearchGroups()
        {
            Driver.WaitForLoader();
            //Add searcg data to the search field
            TxtSearch.SendKeys("Test");
            //Click on the Search button
            BtnSearch.Click();
            //Move to the Search Results
            Driver.MoveToElement(ColumnHeader);
        }

        public void CreateGroup()
        {



        }
    }
}
