using System;
using System.Collections.ObjectModel;
using System.Linq;
using Nancy;
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
            var chord = new Chord(1, "C",new Collection<Fingering>
                {
                    new Fingering{Fret = 0,String = StringEnum.B},
                    new Fingering{Fret = 1,String = StringEnum.D},
                    new Fingering{Fret = 2,String = StringEnum.A}
                });
            _db.Chords.Insert(chord);
        }

        [Given(@"the chord ""(.*)"" does not exist in the chord database")]
        public void GivenTheChordDoesNotExistInTheChordDatabase(string p0)
        {
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
            Assert.Equal(p0,chord.Name);
            foreach (var fingering in p1.Rows)
            {
                var stringName = fingering["String"];
                var fret = Int32.Parse(fingering["Fret"]);
                var chordString = chord.Fingerings.FirstOrDefault(o => o.String.ToString()==stringName);
                Assert.NotNull(chordString);
// ReSharper disable PossibleNullReferenceException
                Assert.Equal(fret,chordString.Fret);
// ReSharper restore PossibleNullReferenceException
            }

        }

        [Then(@"a 404 should be returned from the api")]
        public void ThenAShouldBeReturnedFromTheApi()
        {
            Assert.Equal(HttpStatusCode.NotFound,_apiResponse.StatusCode);
        }
    }
}
