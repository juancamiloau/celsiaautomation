using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using System;
using System.Threading;
namespace Appium
{
    public class Tests
    {
        AppiumOptions options;
        AppiumDriver<AndroidElement> driver;

        [SetUp]
        public void Setup()
        {
            options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("platformVersion", "11");
            options.AddAdditionalCapability("deviceName", "Mi 10T Pro");
            options.AddAdditionalCapability("automationName", "Appium");
            options.AddAdditionalCapability("browserName", "Chrome");
            options.AddAdditionalCapability("chromedriverExecutableDir", @"C:\BrowserDrivers");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }


        [Test]
        public void Test1()
        {
            driver.Url = "https://www.google.com";
            Thread.Sleep(5000);
            Console.WriteLine(driver.PageSource);
            driver.FindElement(By.XPath("//*[@resource-id='tsf']/android.widget.EditText")).SendKeys("hola");
        }

        [TearDown]
        public void ClearSession()
        {
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}