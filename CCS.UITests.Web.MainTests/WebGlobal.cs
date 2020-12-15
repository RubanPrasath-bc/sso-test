using System;
using CCS.UITests.Web.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Protractor;
using CCS.UITests.Web.Selenium.Pages;
using CCS.UITests.Web.Selenium.Helpers;
using System.Reflection;
using System.IO;
using CCS.UITests.Data;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace CCS.UITests.Web.MainTests
{
    public enum LoginUserType { noLogin, asUser = 1, asSystemAdmin, asManager };

    [SetUpFixture]
    public class WebGlobal
    {
        public static IWebDriver Driver { get; private set; }
        public static TestContext TestContext { get; set; }
        public static NgWebDriver NgDriver { get; private set; } //Protractor driver object
        public static string DefaultDownloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
        private static List<KeyValue> Data { get; set; }
        public static BasePage _basePage = null; //Create BasePage object

        public static BasePage BasePage //Returns a basePage object
        {
            get
            {
                return _basePage;
            }
        }
        
        private static void Startup(string browserName)
        {
            string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        
            if (browserName.Equals("firefox"))
            {               
                FirefoxOptions options = new FirefoxOptions();
                options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/octet-stream");
                Driver = new FirefoxDriver(driverPath, options);
                Driver.Manage().Window.Maximize();
            }
            else if (browserName.Equals("edge"))
            {
                Driver = new EdgeDriver(driverPath);
            }
            else if(browserName.Equals("chrome"))
            {
                // Using chromedriver options and maximizes the browser window
                var options = new ChromeOptions();
                options.AddArgument("start-maximized");
                options.AddArgument("disable-infobars");
                options.AddArgument("no-sandbox"); //required by cloud hosted agents  
                // set the default download folder
                options.AddUserProfilePreference("download.default_directory", DefaultDownloadsFolder);
                Driver = new ChromeDriver(driverPath, options);
            }
            else
            {
                throw new System.Exception("Invalid broswer name mentioned");
            }
        }
        
        //Launch web url and login ;enum LoginUserType to select login type
        public static void StartupPortal(LoginUserType loginType = LoginUserType.asUser)
        {
            string applicationUrl = TestContext.Parameters["ApplicationUrl"];
            //string adminUsername = TestContext.Parameters["AdminUsername"];
            //string adminPassword = TestContext.Parameters["AdminPassword"];
            string browserToRun = TestContext.Parameters["BrowserToRun"];
            
            Startup(browserToRun);

            NgDriver = new NgWebDriver(Driver);

            NgDriver.IgnoreSynchronization = true;
            LoginPage login = new LoginPage(NgDriver);

            NgDriver.LoadAllElements();

            NgDriver.Navigate().GoToUrl(applicationUrl);

            //switch (loginType)
            //{

            //    case LoginUserType.noLogin:
            //        _basePage = login;
            //        break;

            //    case LoginUserType.asUser:
            //        _basePage = login.LoginUser(adminUsername, adminPassword);
            //        break;

            //    case LoginUserType.asSystemAdmin:
            //        _basePage = login.LoginUser(adminUsername, adminPassword);
            //        break;

               
            //}
        }

        //Read values from the Data.csv
        public static KeyValue GetData(string key)
        {
            Data = DataHelpers.LoadAllData("Data");
            return Data.Where(kv => kv.Key == key).FirstOrDefault();
        }

        //Loads and saves all data
        public static void SetData(string fileName, string key, string value)
        {
            Data = DataHelpers.LoadAllData(fileName);
            foreach (KeyValue KV in Data)
            {
                if (KV.Key == key)
                {
                    KV.Value = "";
                    KV.Value = value;
                    DataHelpers.SaveAllData(Data, fileName);
                }
            }
        }

        //Traverse through the Data.csv and write values if matching keys are found
        private static void SetAllData(string key, string value)
        {
            SetData("Data", key, value); //Loads and saves all data
        }

        public static void Cleanup()
        {
            Driver.Dispose();
            Driver = null;
        }

    }
}
