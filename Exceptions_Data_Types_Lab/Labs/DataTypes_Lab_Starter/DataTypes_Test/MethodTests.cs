using NUnit.Framework;
using DataTypes_Lib;
using System;

namespace DataTypes_Test
{
    public class MethodTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(10, 3_628_800)]
        [TestCase(12, 479_001_600)]
        [TestCase(13, 6_227_020_800)]
        [TestCase(20, 2_432_902_008_176_640_000)]
        public void Factorial_Returns_CorrectInteger(int n, long expResult)
        {
            Assert.That(Methods.Factorial(n), Is.EqualTo(expResult));
        }

        [TestCase(-1)]
        [TestCase(-2)]
        public void GivenNIsNegative_Factorial_ThrowsAnArgumentOutOfRangeException(int n)
        {
            Assert.That(() => Methods.Factorial(n), Throws.TypeOf<ArgumentOutOfRangeException>().
                With.Message.Contain("Negative factorial is not possible."));
        }

        [Test]
        public void Mult_ReturnsCorrectProductOfFloats()
        {
            Assert.That(Methods.Mult(2.1f, 3.0f), Is.EqualTo(6.30000f).Within(0.00005f));           
        }
    }
}