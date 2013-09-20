using System.Collections.Generic;

namespace webservice.Domain
{
    public class Chord
    {
        public Chord(int id, string name, IList<Fingering> fingerings)
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

        public IList<Fingering> Fingerings { get; set; }
    }
}