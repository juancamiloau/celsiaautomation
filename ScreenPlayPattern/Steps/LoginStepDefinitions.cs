
using TechTalk.SpecFlow;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using ScreenPlayPattern.abilities;
using ScreenPlayPattern.ComponentsUI;
using FluentAssertions;

namespace ScreenPlayPattern.Steps
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IActor actor;
        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"(.*) is on SauceDemo")]
        public void GivenActorIsOnSauceDemo(string nameActor)
        {
            IWebDriver driver = _scenarioContext.Get<IWebDriver>("driver");
            actor = new Actor(nameActor);
            actor.Can(BrowseTheWeb.With(driver));
            actor.AttemptsTo(Navigate.ToUrl("https://www.saucedemo.com/"));
        }

        [When(@"he logins on the portal")]
        public void WhenHeLoginsOnThePortal()
        {
            actor.AttemptsTo(SendKeys.To(LoginComponent.UserInput, "standard_user"));
            actor.AttemptsTo(SendKeys.To(LoginComponent.PasswordInput, "secret_sauce"));
            actor.AttemptsTo(Click.On(LoginComponent.LoginButton));
        }

        [Then(@"he should see the products")]
        public void ThenHeShouldSeeTheProducts()
        {
            actor.AsksFor(Appearance.Of(MenuBurguerComponent.MenuButton)).Should().BeTrue();
        }

    }
}
