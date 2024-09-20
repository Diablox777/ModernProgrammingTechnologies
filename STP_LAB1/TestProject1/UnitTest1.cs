namespace Test_Lab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 10, 5 };
            int[] b = { 1, 10, 5 };
            int[] expected = { 2, 20, 10 };

            int[] result = STP_Lab1.Program.SumArray(a, b);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(STP_Lab1.Program.invalid_argument))]
        public void TestMethod2()
        {
            int[] a = { 3, 33, 153 };
            int[] b = { 4, -53, 73, 33 };
            int[] expected = { 4, 1, 2 };

            int[] result = STP_Lab1.Program.SumArray(a, b);
        }

        [TestMethod]
        public void TestMethod3()
        {
            float[] array = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            float[] expected = { 3.0f, 4.0f, 5.0f, 1.0f, 2.0f };
            STP_Lab1.Program.LeftShifting(array, 2);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void TestMethod4()
        {
            float[] array = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            float[] expected = { 4.0f, 5.0f, 1.0f, 2.0f, 3.0f };
            STP_Lab1.Program.LeftShifting(array, -2);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        [ExpectedException(typeof(STP_Lab1.Program.invalid_argument))]
        public void TestMethod5()
        {
            float[] array = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            float[] expected = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            STP_Lab1.Program.LeftShifting(array, 0);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 1, 2 };
            int expected = 0;
            int result = STP_Lab1.Program.FindSubsequence(array1, array2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5 };
            int expected = 2;
            int result = STP_Lab1.Program.FindSubsequence(array1, array2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5 };
            int expected = 3;
            int result = STP_Lab1.Program.FindSubsequence(array1, array2);
            Assert.AreEqual(expected, result);
        }
    }
}