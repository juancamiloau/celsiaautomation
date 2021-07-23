using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Threading;
using OpenQA.Selenium.Appium;

namespace Appium
{
    public class UnitTest2
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
            options.AddAdditionalCapability("appPackage", "com.google.android.apps.translate");
            options.AddAdditionalCapability("appActivity", "com.google.android.apps.translate.TranslateActivity");
            options.AddAdditionalCapability("noReset", "false");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }


        [Test]
        public void Test1()
        {
            driver.FindElement(By.XPath("//*[@text='Traducir sin conexión']")).Click();
            driver.FindElement(By.XPath("//*[@text='LISTO']")).Click();
            driver.FindElement(By.XPath("//*[@text='Configuración']")).Click();
            Console.WriteLine(driver.FindElement(By.Id("android:id/summary")).GetAttribute("text"));

        }

        [TearDown]
        public void ClearSession()
        {
            
            driver.Quit();
        }
    }
}