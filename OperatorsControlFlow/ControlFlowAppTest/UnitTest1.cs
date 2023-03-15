using ControlFlowApp;

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

}