using System.Collections.Generic;
using Nancy;
using chord.ws.Domain;
using chord.ws.Repository;

namespace chord.ws.Modules
{
    public class ChordModule : NancyModule
    {
        public const string ChordUrl = "/chord";
        private readonly IChordRepository _repository;

        public ChordModule(IChordRepository repository)
            : base(ChordUrl)
        {
            _repository = repository;

            Get["/{name}"] = _ =>
                {
                    var chord = _repository.GetByChordName(_.name);
                    return chord ?? new NotFoundResponse();
                };
        }

    }
}
