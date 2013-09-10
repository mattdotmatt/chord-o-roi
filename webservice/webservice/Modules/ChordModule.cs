using Nancy;
using webservice.Repository;

namespace webservice.Modules
{
    public class ChordModule : NancyModule
    {
        public const string ChordUrl = "/chord";
        private readonly IChordRepository m_repository;

        public ChordModule(IChordRepository repository)
            : base(ChordUrl)
        {
            m_repository = repository;

            Get["/{name}"] = p => View["Chord", m_repository.GetByChordName(p.Name)];
        }

    }
}
