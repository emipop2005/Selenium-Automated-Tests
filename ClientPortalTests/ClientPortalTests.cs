using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientPortal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace ClientPortalTests
{
    public class ClientPortalTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            ClientPortal_LoginPage.GoTo(Parameters.integration_URL_client_portal);
            Thread.Sleep(5000);
            ClientPortal_LoginPage.LoginAs(Parameters.username_integration).WithPassword(Parameters.password_integration).Login();
        }

    


        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
