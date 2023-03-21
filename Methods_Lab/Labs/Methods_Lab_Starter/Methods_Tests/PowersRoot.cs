using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods_Lib;
using NUnit.Framework;

namespace Methods_Tests;

public class PowersRoot
{
    [TestCase(4, 16, 64, 2)]
    public void GivenNumberIsGreaterThan0_PowersRoot_ReturnSQR_Cube_SQRT(
        int num, int numSqr, int cube, double numSqrt)
    {
        var answer = Methods.PowersRoot(num);
        Assert.That(answer.numSqr, Is.EqualTo(numSqr));
        Assert.That(answer.cube, Is.EqualTo(cube));
        Assert.That(answer.numSqrt, Is.EqualTo(numSqrt));
    }

    [Test]
    public void GivenANegativeNumber_PowersRoot_ThrowsAnException()
    {
        Assert.That(() => Methods.PowersRoot(-1), Throws.TypeOf<ArgumentException>().
            With.Message.Contain("Number must be greater than 0"));
    }
}
