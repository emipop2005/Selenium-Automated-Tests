using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ClientPortal
{
    public class OneClick_LoginPageElements
    {
        public static IWebElement user_name = Driver.Instance.FindElement(By.Id("username"));
        public static IWebElement pass = Driver.Instance.FindElement(By.Id("password"));
        public static IWebElement login_button = Driver.Instance.FindElement(By.Id("login-button"));
    }
}
