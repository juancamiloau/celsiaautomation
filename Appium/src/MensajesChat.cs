using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SeleniumExtras.PageObjects;
namespace Appium.src
{
    public class MensajesChat:Interacciones
    {
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[@content-desc='Iniciar chat']")]
        IWebElement iniciarChat;
        string nombre ="";
        
        public MensajesChat(AndroidDriver<AppiumWebElement> driver):base(driver)
        {
            PageFactory.InitElements(driver,this);
            base.driver = driver;
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
