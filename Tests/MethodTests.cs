using TestMethod;

namespace Tests
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void ExecutionMethodTest()
        {
            List<int> oldValues = new List<int>() { 1, 2, 3 };
            List<int> expectedValues = new List<int>() { 11, 12, 13 };
            List<int> resultValues = WorkWithNumbers.IncrementValues(oldValues);
            Assert.IsTrue(resultValues.SequenceEqual(expectedValues));
        }

        [TestMethod]
        public void ImmutableDatasTest()
        {
            List<int> oldValues = new List<int>() { 1, 2, 3 };
            List<int> resultValues = WorkWithNumbers.IncrementValues(oldValues);
            Assert.AreNotSame(oldValues, resultValues);
        }
    }
}