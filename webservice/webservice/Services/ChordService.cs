using webservice.Domain;
using webservice.Repository;

namespace webservice.Services
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
    }
}