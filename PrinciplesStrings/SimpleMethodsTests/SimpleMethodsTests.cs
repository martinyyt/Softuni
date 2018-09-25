using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMethods;

namespace SimpleMethodsTests
{
    [TestClass]
    public class SimpleMethodsTests
    {
        [TestMethod]
        public void TestToUpperBetweenTagsWithNoClosingTag()
        {
            //Arrange
            var input = "no closing<tag here";
            //Act
            var result = SimpleMethods.ToUpperBetweenTags(input, "<", ">");
            //Assert
            Assert.AreEqual(input, result);
        }
        [TestMethod]
        public void TestUpperBetweenTagsWithValidTags()
        {
            //Arrange
            var input = "capitalize <this text> for me";
            var expected = "capitalize THIS TEXT for me";

            //Act
            var actual = SimpleMethods.ToUpperBetweenTags(input, "<", ">");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
