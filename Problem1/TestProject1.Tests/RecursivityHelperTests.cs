using NUnit.Framework;
using Problem1;

namespace TestProject1.Tests
{
    public class RecursivityHelperTests
    {
        [Test]
        public void Sum_WhenArrayIsNull_ReturnsZero()
        {
            int[] array = null;
            int sum = RecursivityHelper.Sum(array);
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Sum_WhenArrayIsEmpty_ReturnsZero()
        {
            int[] array = { };
            int sum = RecursivityHelper.Sum(array);
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Sum_WhenArrayContainsASingleElement_ReturnsTheElement()
        {
            int[] array = { 10 };
            int sum = RecursivityHelper.Sum(array);
            Assert.AreEqual(10, sum);
        }

        [Test]
        public void Sum_WhenArrayContainsMultipleElements_ReturnsTheSum()
        {
            int[] array = { 10, 10, 10 };
            int sum = RecursivityHelper.Sum(array);
            Assert.AreEqual(30, sum);
        }
    }
}