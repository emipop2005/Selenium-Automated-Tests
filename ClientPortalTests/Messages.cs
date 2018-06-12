using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientPortal;
using System.Threading;

namespace ClientPortalTests
{
    [TestClass]
    public class Messages : ClientPortalTests
    {
        [TestMethod]
        public void Hide_ClientDetails()
        {
          
            DashboardPage.HideDetails();
            Thread.Sleep(500);
            Assert.IsFalse(DashboardPage.DetailsHidden, "Client details are not minimized ");
        }

    }
}
