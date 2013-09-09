using System.Collections.Generic;
using webservice.Domain;

namespace webservice.Repository
{
    public interface IChordRepository
    {
        ICollection<Chord> GetByChordName(string chordName);
    }
}