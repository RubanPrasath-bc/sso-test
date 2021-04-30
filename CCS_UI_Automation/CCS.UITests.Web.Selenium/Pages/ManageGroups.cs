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
        public IWebElement BtnCreateGroup => Driver.GetClickableXPath("btnCreateGroup");
        public IWebElement TxtGroupName => Driver.GetClickableXPath("txtGroupName");
        public IWebElement BtnSaveAndContinue => Driver.GetClickableXPath("btnSaveAndContinue");       
        public IWebElement CheckboxUser => Driver.GetClickableXPath("checkboxUser");
        public IWebElement BtnContinue => Driver.GetClickableXPath("btnContinue");
        public IWebElement BtnConfirmandContinue => Driver.GetClickableXPath("btnConfirmandContinue");
        public IWebElement CheckboxOrgAdmin => Driver.GetClickableXPath("checkboxOrgAdmin");
        public IWebElement CheckboxOrgUser => Driver.GetClickableXPath("checkboxOrgUser");
        public IWebElement BtnConfirm => Driver.GetClickableXPath("btnConfirm");
        public IWebElement LinkEditGroup => Driver.GetClickableXPath("linkEditGroup");
        public IWebElement BtnChangeGroupName => Driver.GetClickableXPath("btnChangeGroupName");
        public IWebElement BtnSaveChanges => Driver.GetClickableXPath("btnSaveChanges");
        public IWebElement LinkReturnToGroup => Driver.GetClickableXPath("linkReturnToGroup");
        public IWebElement BtnManageGroupRoles => Driver.GetClickableXPath("btnManageGroupRoles");
        public IWebElement CheckboxOrgUserSupport => Driver.GetClickableXPath("checkboxOrgUserSupport");
        public IWebElement CheckboxManageSub => Driver.GetClickableXPath("checkboxManageSub");
        public IWebElement BtnManageUsers => Driver.GetClickableXPath("btnManageUsers");
        public IWebElement CheckboxEditUser1 => Driver.GetClickableXPath("checkboxEditUser1");
        public IWebElement CheckboxEditUser2 => Driver.GetClickableXPath("checkboxEditUser2");
        public IWebElement LinkDeleteGroup => Driver.GetClickableXPath("linkDeleteGroup");
        public IWebElement BtnConfirmandDelete => Driver.GetClickableXPath("btnConfirmandDelete");
        public void SearchGroups()
        {
            Driver.WaitForLoader();

            //Add search data to the search field
            TxtSearch.SendKeys("Automation Test");

            //Click on the Search button
            BtnSearch.Click();

            //Move to the Search Results
            Driver.MoveToElement(ColumnHeader);
            
        }

        public void AddGroupName()
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.GenerateRandomNumber(5, 100);

            Driver.WaitForLoader();
            Driver.MoveToElement(BtnCreateGroup);

            //Click the Create Group button
            BtnCreateGroup.Click();

            //Add a group name
            TxtGroupName.SendKeys("Automation Test Group" + randomNumber);

            //Click on the Save and Continue button
            BtnSaveAndContinue.Click();
            Driver.WaitForLoader();

        }

        public void AddUsersToGroup()
        {
            //Search for a user
            TxtSearch.SendKeys("TestAuto");

            //Click on the Search button
            BtnSearch.Click();
            Driver.WaitForLoader();

            //Select the user
            CheckboxUser.Click();
            Driver.MoveToElement(BtnContinue);

            //Click on the Continue button
            BtnContinue.Click();
            Driver.WaitForLoader();

            //Click on the Confirm and Continue button in next page
            BtnConfirmandContinue.Click();
            Driver.WaitForLoader();
            
        }

        public void AddRolesToGroup()
        {
            //Select the Organization Admin role
            CheckboxOrgAdmin.Click();

            //Select the Organization User role
            CheckboxOrgUser.Click();

            //Click on the Continue button
            BtnContinue.Click();
            Driver.WaitForLoader();

            //Click on the Confirm button
            BtnConfirm.Click();

        }

        public void EditGroupName()
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.GenerateRandomNumber(5, 100);

            Driver.WaitForLoader();

            //Click on the edit link
            LinkEditGroup.Click();
            Driver.WaitForLoader();

            //Click the Change Group Name button
            BtnChangeGroupName.Click();

            //Clear the group name
            TxtGroupName.Clear();

            //Add a new group name
            TxtGroupName.SendKeys("Automation Group" + randomNumber);

            //Click on the Save Changes button
            BtnSaveChanges.Click();
            Driver.WaitForLoader();
           
        }

        public void EditGroupRoles()
        {
            //Click the Return to group link
            LinkReturnToGroup.Click();

            //Move to the Manage Group Roles button
            Driver.MoveToElement(BtnManageGroupRoles);

            //Click on the button Manage Group Roles
            BtnManageGroupRoles.Click();
            Driver.WaitForLoader();

            //Select the roles
            CheckboxOrgUserSupport.Click();
            CheckboxManageSub.Click();

            //Click on the Continue button
            BtnContinue.Click();

            //Click the Confirm button
            BtnConfirm.Click();
            Driver.WaitForLoader();
        }

        public void EditGroupUsers()
        {

            //Click on the Return to group link
            LinkReturnToGroup.Click();

            //Move to the Manage Users button
            Driver.MoveToElement(BtnManageUsers);

            //Click on the Manage Users button
            BtnManageUsers.Click();
            Driver.WaitForLoader();

            //Select the users
            CheckboxEditUser1.Click();
            CheckboxEditUser2.Click();

            //Click on the Continue button
            BtnContinue.Click();

            //Click on the Confirm button
            BtnConfirm.Click();
            Driver.WaitForLoader();
        }

        public void DeleteGroup()
        {
            //Click on the Return to group link
            LinkReturnToGroup.Click();

            //Move to the Delete Group link
            Driver.MoveToElement(LinkDeleteGroup);

            //Click on the Delete Group link
            LinkDeleteGroup.Click();

            //Click on the Confirm and Delete button
            BtnConfirmandDelete.Click();
            Driver.WaitForLoader();

        }



        
    }
}
