using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCS.UITests.Web.Selenium.Controls
{
    public class BaseControl
    {
        public IWebDriver Driver { get; private set; }

        private BaseControl()
        {
        }

        public BaseControl(IWebDriver driver)
        {
            Driver = driver;
        }

    }
}
