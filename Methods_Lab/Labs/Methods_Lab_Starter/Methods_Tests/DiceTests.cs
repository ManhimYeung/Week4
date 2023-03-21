using NUnit.Framework;
using System;
using Methods_Lib;
using System.Globalization;

namespace Methods_Tests;

public class DiceTests
{
    [TestCase(92, 10)]
    [TestCase(155, 7)]
    public void RollDice_ReturnsTheSumOfTheFirstTwoNumbersGenerated(int seed, int expResult) //Nish's answer
    {
        var rng = new Random(seed);
        var result = Methods.RollDice(rng); var testRng = new Random(seed);
        Assert.That(result, Is.EqualTo(expResult));
    }

}
