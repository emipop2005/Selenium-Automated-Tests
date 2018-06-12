using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ClientPortal;

namespace ClientPortal
{
    public class URL
    {
        public static void GoTo(string URL)
        {
            Driver.Instance.Navigate().GoToUrl(URL);
        }
     

    }

}

