using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace ClientPortal
{
    public class OneClick_DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                var Home = Driver.Instance.FindElement(By.Id("Messages & Documents"));
                var url = Parameters.integration_URL_OneClick+ "/html/";
                Thread.Sleep(2000);
                if (Home.Displayed && Driver.Instance.Url.Contains(url))
                    return true;
                return false;

            }
        }
    }
}
