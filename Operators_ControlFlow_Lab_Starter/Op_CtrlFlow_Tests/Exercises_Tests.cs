using Microsoft.VisualBasic;
using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for Compare here
        [TestCase(12, 6, true)]
        [TestCase(14, 2, true)]
        [TestCase(1, 1, false)]
        public void GivenNum1AndNum2_Compare_ReturnBoolOrModulus(int num1, int num2, bool expectedResult)
        {
            Assert.That(Exercises.Compare(num1, num2), Is.EqualTo(expectedResult));
        }
        

        [Test]
        public void GivenList_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void GivenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void GivenAge_TicketTypeTest_ReturnTicketType(int age, string expected)
        {
            Assert.That(Exercises.TicketType(age), Is.EqualTo(expected));
        }

        [TestCase(-1, "Invalid Mark")]
        [TestCase(0, "Fail")]
        [TestCase(1, "Fail")]
        [TestCase(38, "Fail")]
        [TestCase(39, "Fail")]
        [TestCase(40, "Pass")]
        [TestCase(41, "Pass")]
        [TestCase(58, "Pass")]
        [TestCase(59, "Pass")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(61, "Pass with Merit")]
        [TestCase(73, "Pass with Merit")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(76, "Pass with Distinction")]
        [TestCase(99, "Pass with Distinction")]
        [TestCase(100, "Pass with Distinction")]
        [TestCase(101, "Invalid Mark")]
        public void GivenMark_Grade_ReturnGrade(int mark, string expectedResult)
        {
            Assert.That(Exercises.Grade(mark), Is.EqualTo(expectedResult));
        }

        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3, 50)]
        [TestCase(4, 20)]
        public void GivenLevel_GetScottishMaxWeddingNumbers_ReturnMaxAttendees(int level, int maxAttendees)
        {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(level), Is.EqualTo(maxAttendees));
        }
    }
}
