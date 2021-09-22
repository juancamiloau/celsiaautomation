using System;
using System.Collections.Generic;
using System.Text;
using Boa.Constrictor.Screenplay;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace ScreenPlayPattern.abilities
{

    //EJEMPLO DE COMO CREAR UNA HABILIDAD
    public class BrowseTheWebMyDriver : IAbility
    {

        public IWebDriver driver { get; }

        private BrowseTheWebMyDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito", "start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static BrowseTheWebMyDriver WithMyDriver()
        {
            return new BrowseTheWebMyDriver();
        }
    }
}
