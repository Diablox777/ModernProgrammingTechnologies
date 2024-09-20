namespace Test_Lab1
{
    [TestClass]
    public class UnitTest1
    {
        // Test for empty array in ProductEvenIndices
        [TestMethod]
        [ExpectedException(typeof(STP_Lab1.Program.invalid_argument))]
        public void TestProductEvenIndices_EmptyArray()
        {
            float[] array = { };
            STP_Lab1.Program.ProductEvenIndices(array);
        }

        // Test for null array in ProductEvenIndices
        [TestMethod]
        [ExpectedException(typeof(STP_Lab1.Program.invalid_argument))]
        public void TestProductEvenIndices_NullArray()
        {
            float[] array = null;
            STP_Lab1.Program.ProductEvenIndices(array);
        }

        // Test ProductEvenIndices with negative values
        [TestMethod]
        public void TestProductEvenIndices_NegativeValues()
        {
            float[] array = { -1.0f, -2.0f, -3.0f, 4.0f, 5.0f };
            float expected = 15.0f; // (-1 * -3 * 5)
            float result = STP_Lab1.Program.ProductEvenIndices(array);
            Assert.AreEqual(expected, result);
        }

        // Test LeftShifting with shift = 0 (expected exception)
        [TestMethod]
        [ExpectedException(typeof(STP_Lab1.Program.invalid_argument))]
        public void TestLeftShifting_ZeroShift()
        {
            float[] array = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            STP_Lab1.Program.LeftShifting(array, 0);
        }

        // Test LeftShifting with negative shift
        [TestMethod]
        public void TestLeftShifting_NegativeShift()
        {
            float[] array = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            float[] expected = { 4.0f, 5.0f, 1.0f, 2.0f, 3.0f };
            STP_Lab1.Program.LeftShifting(array, -2);
            CollectionAssert.AreEqual(expected, array);
        }

        // Test MaxEvenElementEvenIndex with no even element
        [TestMethod]
        [ExpectedException(typeof(STP_Lab1.Program.invalid_argument))]
        public void TestMaxEvenElementEvenIndex_NoEvenElement()
        {
            int[] array = { 3, 1, 7, 9, 11 };
            int index;
            STP_Lab1.Program.MaxEvenElementEvenIndex(array, out index);
        }

        // Test MaxEvenElementEvenIndex with multiple even elements
        [TestMethod]
        public void TestMaxEvenElementEvenIndex_MultipleEvenElements()
        {
            int[] array = { 4, 2, 6, 7, 8, 5, 10 };
            int expectedMax = 10;
            int expectedIndex = 6;
            int index;
            int result = STP_Lab1.Program.MaxEvenElementEvenIndex(array, out index);
            Assert.AreEqual(expectedMax, result);
            Assert.AreEqual(expectedIndex, index);
        }
    }
}
