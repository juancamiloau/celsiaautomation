using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectExample.src;
using System.Threading;
using FluentAssertions;
namespace PageObjectExample
{
    public class TestUnitariosManuales
    {
        
        ChromeDriver driver;
        LoginPage login;
        MenuComponent menu;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://app.alegra.com/");
            login = new LoginPage(driver);
            menu = new MenuComponent(driver);
        }

        [Test]
        public void LoginSuccess()
        {
            login.IngresarUsuario("FSD@gmail.com");
            login.IngresarPassword("INGRESAR VALIDO");
            login.ClickIngresar();
            bool menuVisible = menu.ObtenerVisibilidadMenu();
            menuVisible.Should().BeTrue();
        }

        [Test]
        public void LoginFailed()
        {

            login.ConUsuarioYPassword("sdfsdf@gmail.com", "colovvvv");
            string mensaje = login.obtenerMensajeFallido();
            mensaje.Should().Be("Usuario o clave inválida. ¡Inténtalo de nuevo!");
        }

        [TearDown]
        public void Clean()
        {
            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}