﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;


namespace ClientPortal
{
    public static class ClientPortal_LoginPage
    {



        public static bool IncorrectCredentials
        {
            get
            {
                var incorrect_credentials_message = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/form/div[1]/ul/li"));
                if (incorrect_credentials_message.Displayed)
                    return true;
                return false;

            }
        }

        public static bool IsAt
        {
            get
            {
                ClientPortal_LoginPageElements element = new ClientPortal_LoginPageElements();
                Thread.Sleep(2000);

                if (element.pass.Displayed && element.user_name.Displayed && Driver.Instance.Url.Contains(ClientPortal_LoginPageElements.url))
                    return true;
                return false;

            }
        }

       public static void GoTo(string URL)
        {
            
            Driver.Instance.Navigate().GoToUrl(URL);          
        }


        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;
        public LoginCommand(string userName)
        {
            this.userName = userName;

        }

        public void Login()
        {
            ClientPortal_LoginPageElements element = new ClientPortal_LoginPageElements();



            element.user_name.SendKeys(userName);
            element.pass.SendKeys(password);
            element.login_button.Click();



            
        }

        public LoginCommand WithPassword (string password)
        {
            this.password = password;
            return this;
        }
    }
}
