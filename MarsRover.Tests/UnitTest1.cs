using System.Globalization;
using csharp_mars_rover;
namespace MarsRover.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Successfully_Runs_A_Test()
        {
            Assert.That(true, Is.True);
        }
       
        [Test]
        public void Testing_Parser_To_Filter_Commands_From_Input ()
        {
           //Arrange
            InstructionsParser parser = new InstructionsParser();

            //Act
            string result = parser.ParseInstructions("LRVVV");
            //Assert
            Assert.That(result, Is.EqualTo(("LR")));
        }

        [Test]
        public void Testing_Plateau_Setup()
        {
            //Arrange
            int x = 5;
            int y = 5;
            //Act
            Plateau.SetPlateauCoordinates(x, y, CardinalDirections.North);
            //Assert
            Assert.That(Plateau.X, Is.EqualTo(x));
            Assert.That(Plateau.Y, Is.EqualTo(x));
        }
    }
}