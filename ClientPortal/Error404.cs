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
        public  IWebElement Take_me_back_to_Dashboard = Driver.Instance.FindElement(By.XPath("/html/body/div/a"));
        public  IWebElement p1 = Driver.Instance.FindElement(By.XPath("/html/body/div/div[2]"));
        public  IWebElement p2 = Driver.Instance.FindElement(By.XPath("/html/body/div/div[3]"));
        public  IWebElement p3 = Driver.Instance.FindElement(By.XPath("/html/body/div/div[4]"));
        public  IWebElement image = Driver.Instance.FindElement(By.XPath("/html/body/div/div[1]/img"));

        public bool IsAt
        {
            get
            {

                Thread.Sleep(4000);
                if (Take_me_back_to_Dashboard.Displayed && Take_me_back_to_Dashboard.Enabled && p1.Displayed && p2.Displayed && p3.Displayed && image.Displayed)
                    return true;
                return false;

            }
        }

        public void Revert_to_OC_login_page()

        {
            Take_me_back_to_Dashboard.Click();
        }
    }
}
