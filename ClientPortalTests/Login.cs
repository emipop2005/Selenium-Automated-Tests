using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientPortal;
using System.Threading;


namespace ClientPortalTests
{
    [TestClass]
    public class Login_Tests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Login_successfully()
        {

            ClientPortal_LoginPage.GoTo(Parameters.integration_URL_client_portal);
            ClientPortal_LoginPage.LoginAs("client_1@mailinator.com").WithPassword("1").Login();
            Thread.Sleep(1000);
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login");

        }
     
        [TestMethod]
        public void Login_WrongUsername()
        {
            ClientPortal_LoginPage.GoTo(Parameters.integration_URL_client_portal);
            ClientPortal_LoginPage.LoginAs("client_1111@mailinator.com").WithPassword("1").Login();
            Thread.Sleep(1000);
            Assert.IsTrue(ClientPortal_LoginPage.IncorrectCredentials, "Login successfully");

        }
      
        [TestMethod]
        public void Login_WrongPassword()
        {
            ClientPortal_LoginPage.GoTo(Parameters.integration_URL_client_portal);
            ClientPortal_LoginPage.LoginAs("client_1@mailinator.com").WithPassword("123456").Login();
            Assert.IsTrue(ClientPortal_LoginPage.IncorrectCredentials, "Login successfully");

        }
    

 

        [TestMethod]
        public void Login_NoUsername_CorrectPassword()
        {
            ClientPortal_LoginPage.GoTo(Parameters.integration_URL_client_portal);
            ClientPortal_LoginPage.LoginAs("").WithPassword("123456").Login();
            Assert.IsTrue(ClientPortal_LoginPage.IncorrectCredentials, "Login successfully");

        }

     
        [TestMethod]
        public void Login_CorrectUsername_NoPassword()
        {
            ClientPortal_LoginPage.GoTo(Parameters.integration_URL_client_portal);
            ClientPortal_LoginPage.LoginAs("client_1@mailinator.com").WithPassword("").Login();
            Assert.IsTrue(ClientPortal_LoginPage.IncorrectCredentials, "Login successfully");

        }
       

        [TestMethod]
        public void Login_NoUsername_NoPassword()
        {
            ClientPortal_LoginPage.GoTo(Parameters.integration_URL_client_portal);
            ClientPortal_LoginPage.LoginAs("").WithPassword("").Login();
            Assert.IsTrue(ClientPortal_LoginPage.IncorrectCredentials, "Login successfully");

        }
 
        [TestMethod]
        public void OneClick_Login()
        {
            OneClick_LoginPage.GoTo(Parameters.integration_URL_OneClick);
            Thread.Sleep(7000);
            OneClick_LoginPage.LoginAs("client_1@mailinator.com").WithPassword("1").Login();
            Thread.Sleep(9000);
            Assert.IsTrue(OneClick_DashboardPage.IsAt, "Dashboard page is NOT loaded");


        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
        


        




    
}
