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
        public void Testing_Parser_To_Filter_Invalid_Commands_From_Input ()
        {
           //Arrange
           string input = "LRMLLRRSSDDAS";
            //Act
            string result = InstructionsParser.ParseInstructions(input);
            //Assert
            Assert.That(result, Is.EqualTo("LRMLLRR"));
        }

    }
}