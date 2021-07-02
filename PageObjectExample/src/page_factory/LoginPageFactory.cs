using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
namespace PageObjectExample.src.page_factory
{
    public class LoginPageFactory
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Correo']")]
        private IWebElement inputCorreo;

        public LoginPageFactory(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void IngresarCorreo(String correo)
        {
            inputCorreo.SendKeys(correo);
        }
    }
}
