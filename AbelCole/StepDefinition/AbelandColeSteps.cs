using AbelCole.PageObject;
using System;
using TechTalk.SpecFlow;

namespace AbelCole.StepDefinition
{
    [Binding]
    public class AbelandColeSteps
    { 
        AbelandColePage abelandColePage;
    
    public AbelandColeSteps()
    {
        abelandColePage = new AbelandColePage();
    }







    
        [Given(@"Navigate to website""(.*)""")]
        public void GivenNavigateToWebsite(string p0)
        {
            abelandColePage.NavigatetoWebsite();
        }
        
        [Given(@"click on accept cookies")]
        public void GivenClickOnAcceptCookies()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"click on login")]
        public void GivenClickOnLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter user name""(.*)""")]
        public void GivenEnterUserName(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter password ""(.*)""")]
        public void GivenEnterPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"click on fruit and vegetable boxes")]
        public void GivenClickOnFruitAndVegetableBoxes()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"click on tropical fruit favorites box organics")]
        public void GivenClickOnTropicalFruitFavoritesBoxOrganics()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"click on fruit and veg")]
        public void GivenClickOnFruitAndVeg()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"sd")]
        public void GivenSd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
