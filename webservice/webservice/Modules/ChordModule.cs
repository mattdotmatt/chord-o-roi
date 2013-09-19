using Nancy;
using webservice.Repository;

namespace webservice.Modules
{
    public class ChordModule : NancyModule
    {
        public const string ChordUrl = "/chord";
        private readonly IChordRepository _repository;

        public ChordModule(IChordRepository repository)
            : base(ChordUrl)
        {
            _repository = repository;

            Get["/{name}"] = _ => _repository.GetByChordName(_.name);
        }

    }
}
