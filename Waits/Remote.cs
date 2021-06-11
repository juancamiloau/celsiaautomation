using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
namespace Waits
{
    [TestClass]
    public class Remote
    {

        [TestMethod]
        public void OpenBrowser()
        {
            DesiredCapabilities options = new DesiredCapabilities();
            //ejecutar el chromedriver manual y agregar el puerto
            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:9515"),options);

            driver.Url = "http://google.com";
            Thread.Sleep(10009);
            driver.Quit();
        }
    }
}
