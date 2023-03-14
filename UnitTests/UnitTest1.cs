using CodeToTest;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenATimeof6_Greeting_ReturnsGoodMorning()
        {
            int time = 6;
            string expectedGreeting = "Good Morning";
            string result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenATimeof15_Greeting_ReturnsGoodMorning()
        {
            int time = 15;
            string expectedGreeting = "Good Afternoon";
            string result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenATimeof21_Greeting_ReturnsGoodEvening()
        {
            int time = 21; // Arrange - Given
            string expectedGreeting = "Good Evening"; // Act - When
            string result = Program.Greeting(time); // Assert - Then
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(11)]
        public void GivenATimeLessThan12_MoreThan5_Greeting_ReturnGoodMorning(int timeOfDay)
        {
            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good Morning"));
        }

        [TestCase(13)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(16)]
        [TestCase(17)]
        public void GivenATimeMoreThanOrEqualTo12_LessThanOrEqualTo18_Greeting_ReturnGoodAfternoon(int timeOfDay)
        {
            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good Afternoon"));
        }

        [TestCase(1)]
        [TestCase(99)]
        [TestCase(-1)]
        public void GivenATimeLessThan4_MoreThan18_Greeting_ReturnGoodEvening(int timeOfDay)
        {
            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good Evening"));
        }
    }
}