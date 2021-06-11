using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
namespace Waits
{
    [TestClass]
    public class PageLoadStrategies
    {
        ChromeDriver driver;

        [TestMethod]
        public void PageLoadNormal()
        {
            ChromeOptions options = new ChromeOptions();
            options.PageLoadStrategy = PageLoadStrategy.Eager;
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);
            
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
            driver.Url = "https://demoqa.com/";
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//img[@class='banner-image']"))).Click();
        }

        [TestCleanup]
        public void CloseDriver()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }
    
    }
}
