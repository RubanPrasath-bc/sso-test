using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCS.UITests.Web.MainTests
{
    [TestFixture, Order(1)]
    public class ResetPasswordTest : BaseTest
    {
        [SetUp]
        //Open up the url and login to the system
        public void Login()
        {
            WebGlobal.StartupPortal();

        }

        //Verify the reset password UI functionalities
        [Test, Order(5)]
        public void VerifyResetPassword()
        {


        }

    }
}
