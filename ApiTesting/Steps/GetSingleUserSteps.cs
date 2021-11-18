using Boa.Constrictor.RestSharp;
using Boa.Constrictor.Screenplay;
using RestSharp;
using System;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow;
using FluentAssertions;
using System.Net;
using ApiTesting.Models;
using Newtonsoft.Json.Linq;
using ApiTesting.Requests;

namespace ApiTesting.Steps
{
    [Binding]
    public class GetSingleUserSteps
    {

        private IActor Actor;
        private IRestResponse<User> Response;

        [Given(@"that (.*) connect to (.*)")]
        public void GivenThatJuanConnectToHttpsReqres_In(string nameActor, string URL)
        {
            Actor = new Actor(nameActor);
            Actor.Can(CallRestApi.Using(ClientReqRes.WithURL(URL)));
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
    }
}
