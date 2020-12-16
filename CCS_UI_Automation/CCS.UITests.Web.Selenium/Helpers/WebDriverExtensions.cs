using CCS.UITests.Data;
using CsvHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace CCS.UITests.Web.Selenium.Helpers
{
    public enum Status { isDisplayed = 1, isNotDisplayed, isClickable, hasText };
    public static class WebDriverExtensions
    {
        static IDictionary<string, string> _elementMapDictionary;

        /// <summary>
        /// Wait for element method. Will check elemnt is dispalyed, Not dispalyed, Clickable or Has Text
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="status">WebElement status like "isDisplayed"</param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static IWebElement SmartWaitFor(this IWebDriver driver, Status status, By by, int timeout = 50)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until((drv) =>
            {
                try
                {

                    IWebElement elem = driver.FindElement(by);

                    switch (status)
                    {
                        case Status.isDisplayed:
                            return elem.Displayed ? elem : null;
                        case Status.isNotDisplayed:
                            return !elem.Displayed ? elem : null;
                        case Status.isClickable:
                            return (elem.Displayed && elem.Enabled) ? elem : null;
                        case Status.hasText:
                            return (elem.Text.Length > 0) ? elem : null;
                        default:
                            return null;
                    }
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
                catch (NotFoundException)
                {
                    return null;
                }
            });
        }

        /// <summary>
        /// Wait for Loader to disappear
        /// </summary>
        /// <param name="driver"></param>
        //public static void WaitForLoader(this IWebDriver driver) //Waits for the loading overlay to dissapear from the page
        //{
        //    driver.SmartWaitFor(Status.isNotDisplayed, By.XPath(driver.GetElement("loader")));
        //}

        /// <summary>
        /// Wait for Loader to disappear if it appears in the page
        /// </summary>
        /// <param name="driver"></param>
        public static void WaitForLoader(this IWebDriver driver, int timeout = 10)
        {
            driver.Wait(1);
            try
            {
                var loader = driver.FindElement(By.Id(driver.GetElementPathFromCSV("spinner")));
                if (loader.Displayed.Equals(true))
                {
                    driver.SmartWaitFor(Status.isNotDisplayed, By.Id(driver.GetElementPathFromCSV("spinner")), timeout);
                }
                Console.WriteLine("Found loader and wait till it disappears. loader status: " + loader.Displayed);
            }
            catch
            {
                Console.WriteLine("No loader display");
            }
        }

        public static bool IsElementExists(this IWebDriver driver, string element)
        {
            try
            {
                driver.FindElement(By.XPath(driver.GetElementPathFromCSV(element)));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        public static void Wait(this IWebDriver driver, int wait = 1)
        {
            Thread.Sleep(wait * 1000);
        }
        public static void MoveToElement(this IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void ScrollToUp(this IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,-1000)");
        }
        public static void ScrollToDown(this IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,400)");
        }

        /// <summary>
        /// Read elements in csv file and add it to dictonary
        /// </summary>
        /// <param name="driver"></param>
        public static void LoadAllElements(this IWebDriver driver)
        {
            var dataFilePath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\PageElements.csv";
            
            using(var streamReader = File.OpenText(dataFilePath))
            using (CsvReader csv = new CsvReader(streamReader))
            {
                _elementMapDictionary = csv.GetRecords<KeyValue>().ToDictionary(x => x.Key, x => x.Value);
            }

        }

        /// <summary>
        /// Read elements in csv file and add it to dictonary
        /// </summary>
        /// <param name="driver"></param>
        public static string GetElementPathFromCSV(this IWebDriver driver, string key)
        {
            return _elementMapDictionary[key];
        }


        public static IWebElement GetClickableXPath(this IWebDriver driver,string elementXpathString)
        {
            return driver.SmartWaitFor(Status.isClickable, By.XPath(driver.GetElementPathFromCSV(elementXpathString)));
            
        }

        public static IWebElement GetDisplayedXPath(this IWebDriver driver, string elementXpathString)
        {
            return driver.SmartWaitFor(Status.isDisplayed, By.XPath(driver.GetElementPathFromCSV(elementXpathString)));

        }

        public static IWebElement GetDisplayedID(this IWebDriver driver, string elementXpathString)
        {
            return driver.SmartWaitFor(Status.isDisplayed, By.Id(driver.GetElementPathFromCSV(elementXpathString)));

        }

        public static IWebElement GetClickableCss(this IWebDriver driver, string elementXpathString)
        {
            return driver.SmartWaitFor(Status.isDisplayed, By.CssSelector(driver.GetElementPathFromCSV(elementXpathString)));

        }
        public static IWebElement GetClickableName(this IWebDriver driver, string elementXpathString)
        {
            return driver.SmartWaitFor(Status.isDisplayed, By.Name(driver.GetElementPathFromCSV(elementXpathString)));

        }

        public static IWebElement GetClickableID(this IWebDriver driver, string elementXpathString)
        {
            return driver.SmartWaitFor(Status.isDisplayed, By.Id(driver.GetElementPathFromCSV(elementXpathString)));

        }
        public static IWebElement GetClickableXPath(this IWebDriver driver, string elementXpathStringFormat, params string[] args)
        {
            var selector = string.Format(driver.GetElementPathFromCSV(elementXpathStringFormat), args);
            return driver.SmartWaitFor(Status.isClickable, By.XPath(selector));
        }
        public static IWebElement GetXPath(this IWebDriver driver, string elementXpathStringFormat, params string[] args)
        {
            var selector = string.Format(driver.GetElementPathFromCSV(elementXpathStringFormat), args);
            return driver.FindElement(By.XPath(selector));
        }
        
    }
}
