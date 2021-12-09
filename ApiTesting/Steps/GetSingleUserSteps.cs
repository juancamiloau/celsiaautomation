using Boa.Constrictor.RestSharp;
using Boa.Constrictor.Screenplay;
using RestSharp;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow;
using FluentAssertions;
using System.Net;
using ApiTesting.Models;
using ApiTesting.Requests;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System;

namespace ApiTesting.Steps
{
    [Binding]
    public class GetSingleUserSteps
    {

        private readonly ScenarioContext _scenarioContext;

        public GetSingleUserSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        private IActor Actor;
        private IRestResponse<User> Response;

        [Given(@"that (.*) connect to (.*)")]
        public void GivenThatJuanConnectToHttpsReqres_In(string nameActor, string URL)
        {
            Actor = new Actor(nameActor);
            Actor.Can(CallRestApi.Using(ClientReqRes.WithURL(URL)));
            _scenarioContext.Add("actor", Actor);
        }
        
        [When(@"he gets the user (.*)")]
        public void WhenHeGetsTheUser(string idUser)
        {
            Response = Actor.Calls(Rest.Request<User>(GetSingleUserReq.WithID(idUser)));
        }
        
        [Then(@"he should see the response is (.*)")]
        public void ThenHeShouldSeeTheResponseIs(int statusCodeExpected)
        {
            Response.StatusCode.Should().Be(HttpStatusCode.OK);   
        }
        
        [Then(@"he should see that data is correct")]
        public void ThenHeShouldSeeThatDataIsCorrect(Table table)
        {
            Data userExpected = table.CreateInstance<Data>();
            Data userObtained = Response.Data.data;
            userObtained.email.Should().Be(userExpected.email);
            userObtained.first_name.Should().Be(userExpected.first_name);
            userObtained.last_name.Should().Be(userExpected.last_name);

        }


        [Then(@"he should see that the schema is correct")]
        public void ThenHeShouldSeeThatTheSchemaIsCorrect()
        {
            JsonSchemaGenerator generator = new JsonSchemaGenerator();
            JsonSchema schema = generator.Generate(typeof(Data));
            Console.WriteLine(generator.Generate(typeof(User)));

            //JsonSchema jsSchema = JsonSchema.Parse(schema);
            JObject user = JObject.FromObject(Response.Data.data);

            user.IsValid(schema).Should().BeTrue();  
        }


    }
}
