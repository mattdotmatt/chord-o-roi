using Simple.Data;
using chord.ws.Domain;

namespace chord.ws.Repository
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