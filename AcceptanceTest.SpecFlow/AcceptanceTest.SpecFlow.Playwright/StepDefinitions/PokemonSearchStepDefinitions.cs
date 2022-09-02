using System;
using TechTalk.SpecFlow;

namespace AcceptanceTest.SpecFlow.Playwright.StepDefinitions
{
    [Binding]
    public class PokemonSearchStepDefinitions
    {
        [Given("Given a navigate to {string}")]
        public void GivenGivenANavigateTo(string p0)
        {
            throw new PendingStepException();
        }

        [When("I type {string} in the search box")]
        public void WhenITypeInTheSearchBox(string pokemon)
        {
            throw new PendingStepException();
        }

        [When("I click on the search button")]
        public void WhenIClickOnTheSearchButton()
        {
            throw new PendingStepException();
        }

        [Then("I should get redirected to a search result page")]
        public void ThenIShouldGetRedirectedToASearchResultPage()
        {
            throw new PendingStepException();
        }
    }
}
