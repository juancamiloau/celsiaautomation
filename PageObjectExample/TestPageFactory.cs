using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using FluentAssertions;
using PageObjectExample.src.page_factory;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
namespace PageObjectExample
{
    public class TestPageFactory
    {

        ChromeDriver driver;
        LoginPageFactory loginPageFactory;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = 
                System.TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://app.alegra.com/");
            loginPageFactory = new LoginPageFactory(driver);
        }

        [Test]
        public void LoginSuccess()
        {
            loginPageFactory.IngresarCorreo("juancamilo@gfggg.com");
        }

        [TearDown]
        public void Clean()
        {
            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}
