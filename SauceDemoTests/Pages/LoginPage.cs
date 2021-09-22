using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
namespace SauceDemoTests.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement usuario;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "login-button")]
        private IWebElement login;

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void EscribirUsuario(String usuario)
        {
            this.usuario.SendKeys(usuario);
        }

        public void LoguearUsuario(String Usuario, string password)
        {
            
        }
    }
}
