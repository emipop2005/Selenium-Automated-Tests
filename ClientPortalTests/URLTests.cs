using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientPortal;
using System.Threading;

namespace ClientPortalTests
{
    [TestClass]
    public class URLTests

    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
    
        [TestMethod]
        public void URL_OneClick_Complete_URL()
        {

             URL.GoTo(Parameters.production_URL_client_portal);
             Assert.IsTrue(ClientPortal_LoginPage.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
        }

        [TestMethod]
        public void URL_clientspace_redirect()
        {

            URL.GoTo(Parameters.production_URL_OneClick_with_Clientspace);
            Assert.IsTrue(ClientPortal_LoginPage.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
        }

        [TestMethod]
        public void URL_V2017_1_Redirect()
        {

            URL.GoTo(Parameters.production_URL_OneClick_with_Clientspace + "/v2017-1");
            Assert.IsTrue(ClientPortal_LoginPage.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
        }

        [TestMethod]
        public void URL_V2016_3_Redirect()
        {

            URL.GoTo(Parameters.production_URL_OneClick_with_Clientspace + "/v2016-3");
            Assert.IsTrue(ClientPortal_LoginPage.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
        }

        [TestMethod]
        public void URL_V2016_2_Redirect()
        {

            URL.GoTo(Parameters.production_URL_OneClick_with_Clientspace + "/v2016-2");
            Assert.IsTrue(ClientPortal_LoginPage.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
        }

        [TestMethod]
        public void URL_V2015_3_Redirect()
        {

            URL.GoTo(Parameters.production_URL_OneClick_with_Clientspace + "/v2015-3");
            Assert.IsTrue(ClientPortal_LoginPage.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
        }

        [TestMethod]
        public void URL_V2015_2_Redirect()
        {

            URL.GoTo(Parameters.production_URL_OneClick_with_Clientspace + "/v2015-2");
            Assert.IsTrue(ClientPortal_LoginPage.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
        }

        [TestMethod]
        public void URL_V2016_1_Redirect()
        {

            URL.GoTo(Parameters.production_URL_OneClick_with_Clientspace + "/v2016-1");
            Assert.IsTrue(ClientPortal_LoginPage.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
        }

        [TestMethod]
        public void URL_Random_text_after_url()
        {
            
            URL.GoTo(Parameters.production_URL_client_portal + "/asdasdasdasd");
            Error404 error = new Error404();
            Assert.IsTrue(error.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
            error.Revert_to_OC_login_page();
            Thread.Sleep(5000);
            Assert.IsTrue(OneClick_LoginPage.IsAt, "OneClick login page is not loaded after clicking Take me back to dashboard");
        }

        [TestMethod]
        public void URL_Verify_Document()
        {
           
            URL.GoTo(Parameters.production_URL_client_portal + "/asdasdasdasd");
            Error404 error = new Error404();
            Assert.IsTrue(error.IsAt, "[practice_name].accountantspace.co.uk did not load the ClientPortal Login page");
            error.Revert_to_OC_login_page();
            Thread.Sleep(5000);
            Assert.IsTrue(OneClick_LoginPage.IsAt, "OneClick login page is not loaded after clicking Take me back to dashboard");

        } 
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }


    }
}
