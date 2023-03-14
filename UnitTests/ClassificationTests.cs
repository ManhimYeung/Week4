using CodeToTest;

namespace UnitTests;

public class ClassificationTests
{
    [SetUp]
    public void SetUp() { 
    }

    [TestCase(-1)]
    [TestCase(122)]
    [TestCase(123)]
    public void GivenAgeGreaterThanOrEqualTo122_Below0_AvailableClassifications_ReturnInvalidAge(int age) {
        Assert.That(Program.AvailableClassifications(age), Is.EqualTo("Invalid age."));
    }
    
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(11)]
    public void GivenAgeGreaterThanOrEqualTo0_LessThan12_AvailableClassifications_ReturnUANDPG(int age) {
        Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U/PG films are available."));
    }

    
    [TestCase(12)]
    [TestCase(13)]
    public void GivenAgeGreaterThanOrEqualTo12_LessThan15_AvailableClassifications_Return12And12A(int age) {
        Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U/PG/12/12A films are available."));
    }
    
    [TestCase(16)]
    [TestCase(17)]
    public void GivenAgeGreaterThanOrEqualTo15_LessThan18_AvailableClassifications_Return15(int age) {
        Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U/PG/12/12A/15 films are available."));
    }

    [TestCase(18)]
    [TestCase(19)]
    public void GivenAgeGreaterThanOrEqualTo18_LessThan122_AvailableClassifications_ReturnALL(int age) {
        Assert.That(Program.AvailableClassifications(age), Is.EqualTo("All films are available."));
    }


}
