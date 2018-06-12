using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;

namespace ClientPortal
{
    public class Error404
    {
        public static IWebElement Take_me_back_to_Dashboard = Driver.Instance.FindElement(By.XPath("/html/body/div/a"));
        public static IWebElement p1 = Driver.Instance.FindElement(By.XPath("/html/body/div/div[2]"));
        public static IWebElement p2 = Driver.Instance.FindElement(By.XPath("/html/body/div/div[3]"));
        public static IWebElement p3 = Driver.Instance.FindElement(By.XPath("/html/body/div/div[4]"));
        public static IWebElement image = Driver.Instance.FindElement(By.XPath("/html/body/div/div[1]/img"));

        public static bool IsAt
        {
            get
            {

                Thread.Sleep(2000);
                if (Take_me_back_to_Dashboard.Displayed && Take_me_back_to_Dashboard.Enabled && p1.Displayed && p2.Displayed && p3.Displayed && image.Displayed)
                    return true;
                return false;

            }
        }

        public static void Revert_to_OC_login_page()

        {
            Take_me_back_to_Dashboard.Click();
        }
    }
}
