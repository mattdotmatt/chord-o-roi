namespace chord.ws.Domain
{
    public class Fingering
    {
        public int Id { get; set;  }

        public int Fret { get; set; }

        public StringEnum String { get; set; }

        public int ChordId { get; set; }
    }
}