using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
namespace Appium.src
{
    public class Interacciones
    {
        protected AndroidDriver<AppiumWebElement> driver;
        public Interacciones(AndroidDriver<AppiumWebElement> driver)
        {
            this.driver = driver;
        }
    }
}
