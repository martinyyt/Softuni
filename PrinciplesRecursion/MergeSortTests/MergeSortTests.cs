using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingMethods;

namespace MergeSortTests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void TestSort()
        {
            //Arrange
            int[] unsorted = { 4, 6, 12, 8, 42, 13 };
            int[] sorted = { 4, 6, 8, 12, 13, 42 };

            //Act
            MergeSort.Sort(unsorted);

            //Assert
            for (int i = 0; i < unsorted.Length; i++)
            {
                Assert.AreEqual(unsorted[i], sorted[i],"Something went wrong");
            }
        }
    }
}
