using System;
using Nancy.Testing;
using Simple.Data;
using TechTalk.SpecFlow;
using webservice.Modules;
using webservice.Repository;

namespace webservice.tests.FeatureTests.StepDefinitions
{
    [Binding]
    public class ChordRequestSteps
    {
        private Browser _browser;

        public ChordRequestSteps()
        {
                 _browser = new Browser(with =>
          {
              with.Module<ChordModule>();
              with.Dependency<IChordRepository>(new ChordRepository());
          });
        }

        [BeforeScenario]
        public void BeforeEachScenario()
        {
            var adapter = new InMemoryAdapter();
            adapter.SetAutoIncrementKeyColumn("FairyTaleFigure", "ID");

            Database.UseMockAdapter(adapter);
            ScenarioContext.Current.Set(Database.Open(), ScenarioContextKeys.DB);
        }


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

    public static class ScenarioContextKeys
    {
        public const string DB = "database_key";
    }

}
