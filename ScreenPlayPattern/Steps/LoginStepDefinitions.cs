
using TechTalk.SpecFlow;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using ScreenPlayPattern.Models;
using ScreenPlayPattern.ComponentsUI;
using FluentAssertions;
using ScreenPlayPattern.Tasks;
using TechTalk.SpecFlow.Assist;
using System.Configuration;
using Microsoft.Extensions.Configuration;

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

        [Given(@"(.*) was on SauceDemo")]
        [Given(@"(.*) is on SauceDemo")]
        public void GivenActorIsOnSauceDemo(string nameActor)
        {
            IWebDriver driver = _scenarioContext.Get<IWebDriver>("driver");
            actor = new Actor(nameActor);
            actor.Can(BrowseTheWeb.With(driver));
            actor.AttemptsTo(Navigate.ToUrl(_scenarioContext.Get<IConfiguration>("config")["Url"]));
        }

        [Given(@"he logins on the portal")]
        [When(@"he logins on the portal")]
        public void WhenHeLoginsOnThePortal(Table table)
        {

            Credentials credentials = table.CreateInstance<Credentials>();
            //var user = table.Rows[0][0];
            //var password = table.Rows[0][1];
            // actor.AttemptsTo(Login.WithCredentials(credentials.user, credentials.password));
            
            actor.AttemptsTo(Login.WithUser(credentials.user).AndPassword(credentials.password));
        }

        [Then(@"he should see the products")]
        public void ThenHeShouldSeeTheProducts()
        {
            actor.AsksFor(Appearance.Of(MenuBurguerComponent.MenuButton)).Should().BeTrue();
        }

        [When(@"he logins on the portal with wrong credentials")]
        public void WhenHeLoginsOnThePortalWithWrongCredentials()
        {
            //actor.AttemptsTo(Login.WithCredentials("standard_user", "bad_password"));
            actor.AttemptsTo(Login.WithUser("user here").AndPassword("my password"));
        }

        [Then(@"he should see a message that ""(.*)""")]
        public void ThenHeShouldSeeAMessageThat(string message)
        {
            actor.WaitsUntil(Text.Of(LoginComponent.ErrorMessageLabel), IsEqualTo.Value(message));
        }

        [Then(@"he should see a message that")]
        public void ThenHeShouldSeeAMessageThat(Table table)
        {
            var message = table.Rows[0][0];
            actor.WaitsUntil(Text.Of(LoginComponent.ErrorMessageLabel), IsEqualTo.Value(message));
        }


    }
}
