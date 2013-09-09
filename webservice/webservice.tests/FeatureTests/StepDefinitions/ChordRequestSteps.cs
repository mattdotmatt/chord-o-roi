using TechTalk.SpecFlow;

namespace webservice.tests.FeatureTests.StepDefinitions
{
    [Binding]
    public class ChordRequestSteps
    {
        [Given(@"the chord ""(.*)"" exists in the chord database")]
        public void GivenTheChordExistsInTheChordDatabase(string p0)
        {
            // Set up database to contain C chord
        }
        
        [Given(@"the chord ""(.*)"" does not exist in the chord database")]
        public void GivenTheChordDoesNotExistInTheChordDatabase(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I request the chord ""(.*)"" from the api")]
        public void WhenIRequestTheChordFromTheApi(string p0)
        {
            // Request the chord from the api
        }
        
        [Then(@"the representation for the ""(.*)"" chord should be returned by the api")]
        public void ThenTheRepresentationForTheChordShouldBeReturnedByTheApi(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a (.*) should be returned from the api")]
        public void ThenAShouldBeReturnedFromTheApi(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
