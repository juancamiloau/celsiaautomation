using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace PageObjectExample.src
{
    public class LoginPage
    {
        private readonly By correoInput = By.XPath("//input[@placeholder='Correo']");
        private readonly By passwordInput = By.XPath("//input[@id='password']");
        private readonly By ingresarButton = By.XPath("//input[@value='INGRESAR']");
        private readonly By errorMessage = By.XPath("//div[contains(@class,'error')]");
        private readonly IWebDriver driver;
       


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void IngresarUsuario(string usuario)
        {
            driver.FindElement(correoInput).SendKeys(usuario);
        }

        public void IngresarPassword(string password)
        {
            driver.FindElement(passwordInput).SendKeys(password);
        }

        public void ClickIngresar()
        {
            driver.FindElement(ingresarButton).Click();
        }

        public void ConUsuarioYPassword(string usuario, string password)
        {
            IngresarUsuario(usuario);
            IngresarPassword(password);
            ClickIngresar();
        }


        public string obtenerMensajeFallido()
        {
            return driver.FindElement(errorMessage).Text;
        }
    }
}
