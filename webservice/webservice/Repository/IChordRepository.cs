using webservice.Domain;

namespace webservice.Repository
{
    public interface IChordRepository
    {
        Chord GetByChordName(string chordName);
    }
}