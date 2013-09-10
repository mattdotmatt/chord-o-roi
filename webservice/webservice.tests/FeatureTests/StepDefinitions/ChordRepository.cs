using System.Collections.Generic;
using Simple.Data;
using webservice.Domain;
using webservice.Repository;

namespace webservice.tests.FeatureTests.StepDefinitions
{
    public class ChordRepository : IChordRepository
    {
        private dynamic _db;

        public ChordRepository()
        {
            _db = Database.Open();
        }

        public ICollection<Chord> GetByChordName(string chordName)
        {
            return _db.Chords.FindByName(chordName);
        }
    }
}