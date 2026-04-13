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
        public void Rover_First_Action_Is_Move()
        {
         //Arrange
         Rover rover = new Rover;

        }
    }
}