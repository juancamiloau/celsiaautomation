using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using SauceDemoTests.Pages;
    
using FluentAssertions;
namespace SauceDemoTests.Steps
{
    [Binding]
    public class LoginStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private ChromeDriver driver;
        private LoginPage loginPage;
        public LoginStepDefinitions(ScenarioContext _scenarioContext)
        {
            this._scenarioContext = _scenarioContext;
            driver = _scenarioContext.Get<ChromeDriver>("driver");
            loginPage = new LoginPage(driver);
        }


        [Given(@"Juan esta en el inicio de sesión")]
        public void GivenJuanEstaEnElInicioDeSesion()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"él se loguea")]
        public void WhenElSeLoguea()
        {
            loginPage.EscribirUsuario("standard_user");
            
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            
            driver.FindElement(By.Id("login-button")).Click();
            
        }

        [When(@"él se loguea con credenciales incorrectas")]
        public void WhenElSeLogueaConCredencialesIncorrectas()
        {
            loginPage.EscribirUsuario("standard_user");
           
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce2");
            
            driver.FindElement(By.Id("login-button")).Click();
            
        }

        [Then(@"él debería de ver el siguiente mensaje (.*)")]
        public void ThenElDeberiaDeVerElSiguienteMensaje(String mensajeEsperado)
        {
            string mensajeObtenido = driver.FindElement(By.XPath("//h3[@data-test='error']")).Text;
            mensajeObtenido.Should().BeEquivalentTo(mensajeEsperado);
        }

        [Then(@"él debería de ver la página de productos")]
        public void ThenElDeberiaDeVerLaPaginaDeProductos()
        {
            driver.FindElement(By.XPath("//div[@id='inventory_container']")).Displayed.Should().BeTrue();
            
        }
    }
}
