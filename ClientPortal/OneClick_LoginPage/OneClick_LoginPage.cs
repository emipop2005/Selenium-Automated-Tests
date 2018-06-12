using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ClientPortal
{
    public class OneClick_LoginPage
    {
        public static bool IsAt
        {
            get
            {

                Thread.Sleep(2000);
                if (OneClick_LoginPageElements.login_button.Enabled && OneClick_LoginPageElements.user_name.Displayed && OneClick_LoginPageElements.pass.Displayed)
                    return true;
                return false;

            }
        }

        public static void GoTo(string URL)
        {

            Driver.Instance.Navigate().GoToUrl(URL);
        }

        public static LoginCommand_OC LoginAs(string userNamE)
        {
            return new LoginCommand_OC(userNamE);
        }
    }
    public class LoginCommand_OC
    {
        private readonly string userNamE;
        private string Password;
        public LoginCommand_OC(string userName)
        {
            this.userNamE = userName;

        }

        public void Login()
        {

            OneClick_LoginPageElements.user_name.SendKeys(userNamE);
            OneClick_LoginPageElements.pass.SendKeys(Password);
            OneClick_LoginPageElements.login_button.Click();




        }

        public LoginCommand_OC WithPassword(string Password)
        {
            this.Password = Password;
            return this;
        }
    }
    }
