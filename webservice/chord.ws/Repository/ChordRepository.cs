using Simple.Data;
using Simple.Data.MongoDB;
using chord.ws.Domain;

namespace chord.ws.Repository
{
    public class ChordRepository : IChordRepository
    {
        private dynamic _db;

        public ChordRepository()
        {
            _db = Database.Opener.OpenMongo("mongodb://localhost:27017/chord-o-roi"); 
        }

        public Chord GetByChordName(string chordName)
        {           
            return _db.Chords.With(_db.Chords.Fingerings).FindByName(chordName);
        }

        public Chord Add(Chord chord)
        {
            var  x =  _db.Chords.Insert(chord);
            return new Chord();
        }
    }
}