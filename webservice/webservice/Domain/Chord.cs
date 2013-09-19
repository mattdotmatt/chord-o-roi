using System.Collections.ObjectModel;

namespace webservice.Domain
{
    public class Chord
    {
        public Chord(int id, string name, Collection<Fingering> fingerings)
        {
            Id = id;
            Name = name;
            Fingerings = fingerings;
        }

        public Chord()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Collection<Fingering> Fingerings { get; set; }
    }
}