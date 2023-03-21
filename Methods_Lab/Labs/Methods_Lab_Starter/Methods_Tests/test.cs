using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods_Lib;

namespace Methods_Tests;

public class test
{
    [TestCase(10, true)]
    [TestCase(15, true)]
    [TestCase(100, true)]
    public void GivenANumberThatIsDivisiblyBy10Or15_Divisibly_ReturnTrue(int num, bool expected)
    {
        Assert.That(Methods.Divisably(num), Is.EqualTo(expected));
    }


    [TestCase(70, "Too fast")]
    [TestCase(50, "Too quick")]
    [TestCase(30, "Just right")]
    [TestCase(10, "Too slow")]
    [TestCase(0, "Stationary")]
    public void GivenANumberBetween70And100_SpeedChecker_ReturnMessage(int num, string message)
    {
        Assert.That(Methods.SpeedChecker(num), Is.EqualTo(message));
    }

    [TestCase(-1)]
    public void GivenANumberGreaterThan100OrBelow0_SpeedChecker_ThrowsAnArgumentOutOfRangeException(int num)
    {
        Assert.That(() => Methods.SpeedChecker(num), Throws.TypeOf<ArgumentOutOfRangeException>().
            With.Message.Contain("Speed invalid"));
    }

    [Test]
    public void GivenNumAndNumList_Mult_ReturnProduct()
    {
        List<int> numList = new List<int>();
        numList.Add(1);
        numList.Add(4);
        numList.Add(5);
        numList.Add(6);

        Assert.That(Methods.Mult(3, numList), Is.EqualTo(20));
    }

    [TestCase(5)]
    [TestCase(6)]
    public void GivenNumGreaterThanNumList_Mult_ThrowsArgumentOutOfRangeException(int num)
    {
        List<int> numList = new List<int>();
        numList.Add(1);
        numList.Add(4);
        numList.Add(5);
        numList.Add(6);
        Assert.That(() => Methods.Mult(num, numList), Throws.TypeOf<ArgumentOutOfRangeException>().
            With.Message.Contain("Out of range"));
    }
}
