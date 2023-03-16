using ControlFlowApp;
using NUnit.Framework;

namespace ControlFlowAppTest;

public class Tests
{
    [TestCase(50, "Fail")]
    [TestCase(64, "Fail")]
    [TestCase(65, "Pass")]
    [TestCase(66, "Pass")]
    [TestCase(84, "Pass")]
    [TestCase(85, "Distinction")]
    [TestCase(86, "Distinction")]
    public void GivenMarks_GetGrade_ReturnGrades(int marks, string expectedGrade)
    {
        Assert.That(Program.GetGrade(marks), Is.EqualTo(expectedGrade));
    }


    [TestCase(-35)]
    [TestCase(-15)]
    public void WhenTheMarkIsNegative_GetGrade_ThrowsAnArgumentOutOfRangeException(int mark)
    {
        // whenever you want to create a function that will only contain simple expressions
        Assert.That(() => Program.GetGrade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain(" Allowed range 0-100."));
    }

    [TestCase(101)]
    [TestCase(102)]
    [TestCase(999)]
    public void WhenTheMarkisAbove_GetGrade_ThrowsAnArgumentOutOfRangeException(int mark)
    {
        Assert.That(() => Program.GetGrade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.Contain(" Allowed range 0-100."));
    }
}