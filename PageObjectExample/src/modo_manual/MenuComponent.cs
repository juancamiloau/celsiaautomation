using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
namespace PageObjectExample.src
{
    public class MenuComponent
    {
        private readonly IWebDriver driver;
        private readonly By menu = By.Id("menuTogglePanel");
        public MenuComponent(IWebDriver driver)
        {
            this.driver = driver;
        }
        public bool ObtenerVisibilidadMenu()
        {
            return driver.FindElement(menu).Displayed;
        }
    }
}
