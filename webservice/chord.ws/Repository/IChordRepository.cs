using chord.ws.Domain;

namespace chord.ws.Repository
{
    public interface IChordRepository
    {
        Chord GetByChordName(string chordName);
        Chord Add(Chord chord);
    }
}