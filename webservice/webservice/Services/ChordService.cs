using System.Linq;
using webservice.Domain;
using webservice.Repository;

namespace webservice.Services
{
    public class ChordService
    {
        private readonly IChordRepository m_chordRepository;

        public ChordService(IChordRepository chordRepository)
        {
            m_chordRepository = chordRepository;
        }

        public Chord GetChord(string chordName)
        {
            var chord = m_chordRepository.GetByChordName(chordName);
            return chord.FirstOrDefault();
        }
    }
}