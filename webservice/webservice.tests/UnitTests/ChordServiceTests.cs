using System.Collections.ObjectModel;
using FakeItEasy;
using Xunit;
using webservice.Domain;
using webservice.Repository;
using webservice.Services;

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
                                String = StringEnum.B
                            },
                            new Fingering{
                                Fret = 1,
                                String = StringEnum.D
                            },
                            new Fingering{
                                Fret = 2,
                                String = StringEnum.A
                            }
                        }
                };

            var fakeResult = new Collection<Chord> { expected };

            var mockChordRepository = A.Fake<IChordRepository>();
            A.CallTo(() => mockChordRepository
             .GetByChordName("C"))
             .Returns(fakeResult);

            // Act
            var sut = new ChordService(mockChordRepository);
            var result = sut.GetChord("C");

            // Assert
            Assert.Equal(expected, result);

        }

    }
}
