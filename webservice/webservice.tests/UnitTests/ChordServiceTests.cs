using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using FakeItEasy;
using Xunit;

namespace webservice.tests.UnitTests
{
    public class ChordServiceTests
    {
        [Fact]
        public void ChordServiceShouldReturnAChordDescriptionForAFoundChord()
        {
            // Arrange
            var expected = new Chord
                {
                    Id = 1,
                    Name = "C",
                    Fingerings = new Collection<Fingering>
                        {
                            new Fingering{
                                Fret = 0,
                                String = StringEnum.E
                            }
                        }
                };

            var fakeResult = new Collection<Chord> { expected };
            var mockRepository = A.Fake<IRepository<Chord>>();
            A.CallTo(() => mockRepository
                .SearchFor(o => o.Name == "C"))
                .Returns(fakeResult);

            // Act
            var sut = new ChordService(mockRepository);
            var result = sut.GetChord("C");

            // Assert
            Assert.Equal(expected, result);

        }
    }

    public class ChordService
    {
        private readonly IRepository<Chord> m_chordRepository;

        public ChordService(IRepository<Chord> chordRepository)
        {
            m_chordRepository = chordRepository;
        }

        public Chord GetChord(string chordName)
        {
            var chord = m_chordRepository.SearchFor(o => o.Name == chordName);
            return chord.FirstOrDefault();
        }
    }

    public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        ICollection<T> SearchFor(Expression<Func<T, bool>> predicate);
        ICollection<T> GetAll();
        T GetById(int id);
    }

    public enum StringEnum
    {
        E
    }

    public class Fingering
    {

        public int Fret { get; set; }

        public StringEnum String { get; set; }
    }

    public class Chord
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Collection<Fingering> Fingerings { get; set; }
    }
}
