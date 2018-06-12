using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ClientPortal
{
   public static class Parameters
    {
        //public static string chrome_Driver_Location = @"D:\Work\OneClick\automation\ChromeDriver";
        public static string chrome_Driver_Location = @"E:\Work\OneClick\automation\ChromeDriver";
        public static string firefox_driver_location = @"D:\Work\OneClick\automation\FirefoxDriver";

        //URL addressess for ClientPortal/OneClick
        public static string integration_URL_client_portal = "https://oc-2018123.accountantspace-dev.co.uk/messages/";
        public static string integration_URL_OneClick = "https://oc-2018123.accountantspace-dev.co.uk";
        public static string production_URL_client_portal = "https://prod-qatest.accountantspace.co.uk/messages";
        public static string production_URL_OneClick_with_Clientspace = "https://prod-qatest.clientspace.co.uk";

       
       

        //Login credentials for Practice: oc-2018123
        public static string username_integration = "client_1@mailinator.com";
        public static string password_integration = "1";

    }
}
