using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace ClientPortal
{
    public class ClientPortal_LoginPageElements
    {
        
        
        public static string url = "messages/Account/Login?ReturnUrl=%2Fmessages";
        public  IWebElement user_name = Driver.Instance.FindElement(By.Id("UserName"));
        public  IWebElement pass = Driver.Instance.FindElement(By.Id("Password"));
        public  IWebElement login_button = Driver.Instance.FindElement(By.Id("btnLogin"));

    }
}
