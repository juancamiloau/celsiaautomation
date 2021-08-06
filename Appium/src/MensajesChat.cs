using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SeleniumExtras.PageObjects;
namespace Appium.src
{
    public class MensajesChat
    {
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[@content-desc='Iniciar chat']")]
        IWebElement iniciarChat;
        AndroidDriver<AppiumWebElement> driver;
        public MensajesChat(AndroidDriver<AppiumWebElement> driver)
        {
            PageFactory.InitElements(driver,this);
            this.driver = driver;
        }

        public void clicIniciarChat()
        {
            iniciarChat.Click();
        }

        public void EsconderChat()
        {
            driver.HideKeyboard();
        }
    }
}
