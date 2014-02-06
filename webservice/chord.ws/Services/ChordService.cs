using chord.ws.Domain;
using chord.ws.Repository;

namespace chord.ws.Services
{
    public class ChordService
    {
        private readonly IChordRepository _chordRepository;

        public ChordService(IChordRepository chordRepository)
        {
            _chordRepository = chordRepository;
        }

        public Chord GetChord(string chordName)
        {
            return  _chordRepository.GetByChordName(chordName);
        }

        public Chord Add(Chord chord)
        {
            return _chordRepository.Add(chord);
        }
    }
}