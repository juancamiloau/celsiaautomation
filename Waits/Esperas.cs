using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using FluentAssertions;
using System.Threading;
using System;
using SeleniumExtras.WaitHelpers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Waits
{
    [TestClass]
    public class Esperas
    {
        ChromeDriver driver;
        [TestMethod]
        public void BotonInhabilitado()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://demoqa.com/dynamic-properties");
            //driver.Url = "https://demoqa.com/dynamic-properties";
            //driver.FindElement(By.XPath("//button[@id='visibleAfter']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
            IWebElement botonInvisible = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@id='visibleAfter']")));
            Console.WriteLine(botonInvisible.Text);
            IWebElement miOtroElemento = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("")));
            miOtroElemento.Click();
            //botonInvisible.Click();
        }

        [TestMethod]
        public void BotonInhabilitadoEsperaImplicita()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://demoqa.com/dynamic-properties");
            //driver.Url = "https://demoqa.com/dynamic-properties";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//button[@id='visibleAfter']")).Click();
            
        }



        [TestCleanup]
        public void CerrarDriver()
        {
            //Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
