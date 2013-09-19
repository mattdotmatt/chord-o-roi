using Nancy.Testing;
using Simple.Data;
using TechTalk.SpecFlow;
using Xunit;
using webservice.Domain;
using webservice.Modules;
using webservice.Repository;

namespace webservice.tests.FeatureTests.StepDefinitions
{
    [Binding]
    public class ChordRequestSteps
    {
        private dynamic _db;
        private BrowserResponse _apiResponse;

        [BeforeScenario]
        public void BeforeEachScenario()
        {
            var adapter = new InMemoryAdapter();
            Database.UseMockAdapter(adapter);

            _db = Database.Open();
        }


        [Given(@"the chord ""(.*)"" exists in the chord database")]
        public void GivenTheChordExistsInTheChordDatabase(string p0)
        {
            var chord = new Chord(1, "C",null);
            _db.Chords.Insert(chord);
        }

        [Given(@"the chord ""(.*)"" does not exist in the chord database")]
        public void GivenTheChordDoesNotExistInTheChordDatabase(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I request the chord ""(.*)"" from the api")]
        public void WhenIRequestTheChordFromTheApi(string p0)
        {
            var browser = new Browser(with =>
            {
                with.Module<ChordModule>();
                var instance = new ChordRepository();
                with.Dependency<IChordRepository>(instance);
            });

            // Act
            var path = string.Format("/chord/{0}/", p0);
            _apiResponse = browser.Get(path,with => with.Accept("application/json"));
        }

        [Then(@"the following representation for the ""(.*)"" chord should be returned by the api:")]
        public void ThenTheRepresentationForTheChordShouldBeReturnedByTheApi(string p0, Table p1)
        {
            var chord = _apiResponse.Body.DeserializeJson<Chord>();
            Assert.Equal("C",chord.Name);
        }

        [Then(@"a (.*) should be returned from the api")]
        public void ThenAShouldBeReturnedFromTheApi(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
