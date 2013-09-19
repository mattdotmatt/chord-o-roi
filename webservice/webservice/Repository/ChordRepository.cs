using Simple.Data;
using webservice.Domain;

namespace webservice.Repository
{
    public class ChordRepository : IChordRepository
    {
        public Chord GetByChordName(string chordName)
        {
            var db = Database.Open();
            return db.Chords.FindByName(chordName);
        }
    }
}