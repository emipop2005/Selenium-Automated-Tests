using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace ClientPortal
{
   public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                var Home = Driver.Instance.FindElement(By.XPath("/html/body/div/section/ui-view/ui-view/ui-view/div/div[1]/div[1]/div/span"));
                var url = "online/app/home";
                Thread.Sleep(2000);
                if (Home.Displayed && Driver.Instance.Url.Contains(url))
                    return true;
                return false;

            }
        }

        public static bool DetailsHidden
        {
            get
            {
                var messages_widget = Driver.Instance.FindElement(By.XPath("/html/body/div/section/ui-view/ui-view/ui-view/div/div[1]/div[2]/div[1]/swimlane/div/div/div[2]/messages-widget/div"));
                var documents_widget = Driver.Instance.FindElement(By.XPath("/html/body/div/section/ui-view/ui-view/ui-view/div/div[1]/div[2]/div[1]/swimlane/div/div/div[2]/documents-widget/div"));
                var documents_to_approve_widget = Driver.Instance.FindElement(By.XPath("/html/body/div/section/ui-view/ui-view/ui-view/div/div[1]/div[2]/div[1]/swimlane/div/div/div[2]/doc-to-approve-widget/div/div"));
                if (messages_widget.Displayed && documents_widget.Displayed && documents_to_approve_widget.Displayed)
                    return true;
                return false;
            }
            
        }

        public static void HideDetails ()
        {
            Thread.Sleep(5000);
            var minimize = Driver.Instance.FindElement(By.XPath("/html/body/div/section/ui-view/ui-view/ui-view/div/div[1]/div[2]/div[1]/swimlane/div/div/div[1]/div[3]"));
            minimize.Click();
        }
    }
}
