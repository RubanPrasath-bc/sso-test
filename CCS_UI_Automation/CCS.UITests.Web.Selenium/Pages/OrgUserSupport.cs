using CCS.UITests.Web.Selenium.Helpers;
using CCS.UITests.Web.Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace CCS.UITests.Web.Selenium.Pages
{
    public class OrgUserSupport : BasePage
    {
        public OrgUserSupport(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement TxtSearch => Driver.GetClickableXPath("txtSearch");
        public IWebElement BtnSearch1 => Driver.GetClickableXPath("btnSearch1");
        public IWebElement LabelResult => Driver.GetClickableXPath("labelSearcgResult");
        public IWebElement BtnContinue => Driver.GetClickableXPath("btnContinue");
        public IWebElement CheckboxAssignOrgAdmin => Driver.GetClickableXPath("checkboxAssignOrgAdmin");
        public IWebElement BtnSaveandContinue1 => Driver.GetClickableXPath("btnSaveandContinue1");
        public IWebElement LabelResetPW => Driver.GetClickableXPath("labelResetPW");

        public void SearchOrganization()
        {

            Driver.WaitForLoader();

            //Enter the username in the serach field
            TxtSearch.SendKeys("KAWSHI");

            //Click on the Search button
            BtnSearch1.Click();
            Driver.WaitForLoader();

            //Select the Search results
            LabelResult.Click();
            Driver.WaitForLoader();

        }

        public void ManageOrgAdminRole()
        {

            Driver.WaitForLoader();

            //Select a user
            LabelResult.Click();

            //Click on the Continue button
            BtnContinue.Click();
            Driver.WaitForLoader();

            //Select the Assign/Unassign admin role check box
            CheckboxAssignOrgAdmin.Click();

            //Click on the Save and Continue button
            BtnSaveandContinue1.Click();
            Driver.WaitForLoader();

        }

        public void UserResetPW()
        {
            Driver.WaitForLoader();

            //Select a user
            LabelResult.Click();

            //Click on the Continue button
            BtnContinue.Click();
            Driver.WaitForLoader();

            //Select the Reset user password check box
            LabelResetPW.Click();

            //Click on the Save and Continue button
            BtnSaveandContinue1.Click();
            Driver.WaitForLoader();

            //Click on the COntinue button
            BtnContinue.Click();
            Driver.WaitForLoader();

        }


    }
}
