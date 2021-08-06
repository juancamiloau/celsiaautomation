using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Threading;
using OpenQA.Selenium.Appium;
using Appium.src;
namespace Appium
{
    public class UnitTest2
    {
        AppiumOptions options;
        AndroidDriver<AppiumWebElement> driver;

        [SetUp]
        public void Setup()
        {
            options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("platformVersion", "11");
            options.AddAdditionalCapability("deviceName", "Mi 10T Pro");
            options.AddAdditionalCapability("automationName", "Appium");
            options.AddAdditionalCapability("appPackage", "com.google.android.apps.messaging");
            options.AddAdditionalCapability("appActivity", "com.google.android.apps.messaging.ui.ConversationListActivity");
            options.AddAdditionalCapability("noReset", "true");
            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), options);
        }


        [Test]
        public void Test1()
        {
            MensajesChat mensajesChat = new MensajesChat(driver);
            mensajesChat.clicIniciarChat();
            mensajesChat.EsconderChat();

           

            bool encontroContacto = false;
            do
            {
                try
                {
                    encontroContacto = driver.FindElement(By.XPath("//*[@text='An Hector Fabio Devot Celsia']")).Displayed;
                }
                catch(Exception e)
                {

                }
                
                Swipe();

            } while (encontroContacto == false);

        }

        public void Swipe()
        {
            

            TouchAction touchAction = new TouchAction(driver);
            touchAction.Press(500, 2148)
                .MoveTo(500, 400).Release().Perform();
        }

        [TearDown]
        public void ClearSession()
        {
            
            driver.Quit();
        }
    }
}