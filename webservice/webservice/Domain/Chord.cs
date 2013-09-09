using System.Collections.ObjectModel;

namespace webservice.Domain
{
    public class Chord
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Collection<Fingering> Fingerings { get; set; }
    }
}