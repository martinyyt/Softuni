using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DifferentWordsInStrings;



namespace DifferentWordsInStringsTests
{
    [TestClass]
    public class DifferentWordsInStringTest
    {
        [TestMethod]
        public void PrintSortedWordsTest1()
        {
            var input = "dafa afaf, dafa, dsf afaf da dafa fad; dafa, dsf.";
                        
            var expected = "afaf - 2\n" +
                "da - 1\n" +
                "dafa - 4\n" +
                "dsf - 2\n" +
                "fad - 1\n";

            var actual = DifferentWordsInString.PrintSortedWords(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
