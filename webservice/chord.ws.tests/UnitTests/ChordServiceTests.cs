using System.Collections.ObjectModel;
using FakeItEasy;
using Xunit;
using chord.ws.Domain;
using chord.ws.Repository;
using chord.ws.Services;

namespace webservice.tests.UnitTests
{
    public class ChordServiceTests
    {
        [Fact]
        public void ChordServiceShouldReturnAChordDescriptionForAFoundChord()
        {
            // Arrange
            var expected = new Chord(1, "C", new Collection<Fingering>
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
                );

            var mockChordRepository = A.Fake<IChordRepository>();
            A.CallTo(() => mockChordRepository
             .GetByChordName("C"))
             .Returns(expected);

            // Act
            var sut = new ChordService(mockChordRepository);
            var result = sut.GetChord("C");

            // Assert
            Assert.Equal(expected, result);

        }

    }
}
