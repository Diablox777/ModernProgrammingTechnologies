namespace Test_Lab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProductEvenIndices()
        {
            float[] array = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            float expected = 15.0f; // 1 * 3 * 5
            float result = STP_Lab1.Program.ProductEvenIndices(array);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLeftShifting()
        {
            float[] array = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            float[] expected = { 3.0f, 4.0f, 5.0f, 1.0f, 2.0f };
            STP_Lab1.Program.LeftShifting(array, 2);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void TestMaxEvenElementEvenIndex()
        {
            int[] array = { 3, 2, 4, 7, 6, 5, 8 };
            int expectedMax = 8;
            int expectedIndex = 6;
            int index;
            int result = STP_Lab1.Program.MaxEvenElementEvenIndex(array, out index);
            Assert.AreEqual(expectedMax, result);
            Assert.AreEqual(expectedIndex, index);
        }
    }
}
