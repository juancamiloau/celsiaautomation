using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace Waits
{
    [TestClass]
    public class ControladorRemoto
    {
        [TestMethod]
        public void AbrirDriver()
        {
            var caps = new OpenQA.Selenium.RemoteSessionSettings();
            caps.AddMetadataSetting("browserName", "Chrome");
            caps.AddMetadataSetting("version", "87");
            caps.AddMetadataSetting("platform", "Windows 8.1");
            caps.AddMetadataSetting("screenResolution", "1366x768");
            caps.AddMetadataSetting("username", "SE OBTEIENEN DE ");
            caps.AddMetadataSetting("password", "https://crossbrowsertesting.com/");
            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://hub.crossbrowsertesting.com:80/wd/hub"),caps);

            driver.Url = "http://google.com";
            driver.FindElement(By.Name("q")).SendKeys("Prueba de remote web driver");
            
            driver.Quit();
        }
    }
}
