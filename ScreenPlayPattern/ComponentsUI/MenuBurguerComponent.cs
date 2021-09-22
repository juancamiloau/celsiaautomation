using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenPlayPattern.ComponentsUI
{
    public static class MenuBurguerComponent
    {
        public readonly static IWebLocator MenuButton = new WebLocator("Menu button", By.XPath("//button[@id='react-burger-menu-btn']"));
    }
}
