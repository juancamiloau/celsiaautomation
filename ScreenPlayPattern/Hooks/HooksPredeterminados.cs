using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ScreenPlayPattern.Hooks
{
    [Binding]
    public class HooksPredeterminados
    {
        private ScenarioContext _scenarioContext;

        public HooksPredeterminados (ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUpDriver()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            Console.WriteLine(configuration["MyConfig:ApplicationName"]);
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito", "start-maximized");
            ChromeDriver driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _scenarioContext.Add("driver", driver);
        }

        [AfterScenario]
        public void CerrarDriver(){
            Thread.Sleep(5000);
            _scenarioContext.Get<ChromeDriver>("driver").Quit();
        }
    }
}
