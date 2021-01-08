using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCS.UITests.Web.MainTests
{
    [TestFixture, Order(1)]
    public class DashboardTest : BaseTest
    {

        [SetUp]
        //Open up the url in browser and login to the system
        public void Login()
        {
            WebGlobal.StartupPortal();

        }


        //Verify the Dashboard page UI functionalities
        [Test, Order(3)]
        public void VerifyDashboardPage()
        {


        }

        //Verify the SSO page launch functionality
        [Test, Order(4)]
        public void VerifySSOLaunch()
        {


        }
    }
}
