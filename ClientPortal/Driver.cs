﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientPortal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace ClientPortal
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
      
            Instance = new ChromeDriver(Parameters.chrome_Driver_Location);          
           /////asdasdasda
        //    Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

          //  Instance = new FirefoxDriver();
          //  Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);




        }

        public static void Close()
        {
            Instance.Close();
        }
        

    }

   
}
