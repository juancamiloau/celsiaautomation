using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;

namespace ScreenPlayPattern.ComponentsUI
{
    public class LoginComponent
    {
        public readonly static IWebLocator UserInput = new WebLocator("user input", By.XPath("//input[@id='user-name']"));
        public readonly static IWebLocator PasswordInput = new WebLocator("password input", By.XPath("//input[@id='password']"));
        public readonly static IWebLocator LoginButton = new WebLocator("login input", By.XPath("//input[@id='login-button']"));
        public readonly static IWebLocator ErrorMessageLabel = new WebLocator("Message label", By.XPath("//h3[@data-test='error']"));
    }
}
