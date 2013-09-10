using System.Collections.Generic;
using Simple.Data;
using webservice.Domain;

namespace webservice.Repository
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