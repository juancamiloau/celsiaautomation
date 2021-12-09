using Boa.Constrictor.RestSharp;
using Boa.Constrictor.Screenplay;
using System;
using TechTalk.SpecFlow;
using ApiTesting.Requests;
using ApiTesting.Models;
using RestSharp;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using FluentAssertions;

namespace ApiTesting.Steps
{
    [Binding]
    public class GestionVacunasStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private Actor Actor;
        private IRestResponse<ResponseVaccines> Response;
        public GestionVacunasStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            Actor = scenarioContext.Get<Actor>("actor");
        }

        [When(@"he gets of vaccines for city")]
        public void WhenHeGetsOfVaccinesForCity()
        {
            Response = Actor.Calls(Rest.Request<ResponseVaccines>(GetVaccinesPerCity.WithTokenAndClientHashId("<TOKEN>"
                , "<HASHID>")));
        }

        [Then(@"he should see the schema is correct")]
        public void ThenHeShouldSeeTheSchemaIsCorrect()
        {
            JsonSchemaGenerator generator = new JsonSchemaGenerator();
            JsonSchema schema = generator.Generate(typeof(ResponseVaccines));
            Console.WriteLine(generator.Generate(typeof(ResponseVaccines)));

            //JsonSchema jsSchema = JsonSchema.Parse(schema);
            JObject user = JObject.FromObject(Response.Data);

            user.IsValid(schema).Should().BeTrue();
        }
    }
}
