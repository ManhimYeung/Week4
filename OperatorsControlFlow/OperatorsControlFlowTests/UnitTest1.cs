using OperatorsApp;

namespace OperatorsControlFlowTests
{
    public class Tests
    {
        [TestCase(14, 1)]
        [TestCase(156, 11)]
        [TestCase(200, 14)]
        public void GivenPounds_GetStones_ReturnsStones(int totalPounds, int expectedStones)
        {
            Assert.That(Method.GetStones(totalPounds), Is.EqualTo(expectedStones));
        }

        [TestCase(14, 0)]
        [TestCase(156, 2)]
        [TestCase(200, 4)]
        public void GivenPounds_GetPounds_ReturnsPounds(int totalPounds, int expectedPounds)
        {
            Assert.That(Method.GetPounds(totalPounds), Is.EqualTo(expectedPounds));
        }

        
    }
}