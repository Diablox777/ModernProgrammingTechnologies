using System;

namespace STP_Lab1
{
    public class Program
    {
        public class invalid_argument : ArgumentException
        {
            public invalid_argument(string mes)
            {
                Console.WriteLine(mes);
            }
        }

        // Function to calculate the product of elements at even indices
        public static float ProductEvenIndices(float[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new invalid_argument("Array is empty or null.");
            }

            float product = 1;
            for (int i = 0; i < array.Length; i += 2)
            {
                product *= array[i];
            }

            return product;
        }

        // Function to cyclically shift an array
        public static void LeftShifting(float[] array, int shift)
        {
            int lengthArray = array.Length;
            if (lengthArray == 0)
            {
                Console.WriteLine("The input array is empty");
                return;
            }

            shift = shift % lengthArray;
            if (shift == 0)
            {
                throw new invalid_argument("Shift value is 0!");
            }

            float[] temp = new float[Math.Abs(shift)];

            if (shift < 0)
            {
                shift = Math.Abs(shift);
                Array.Copy(array, lengthArray - shift, temp, 0, shift);
                Array.Copy(array, 0, array, shift, lengthArray - shift);
                Array.Copy(temp, 0, array, 0, shift);
            }
            else
            {
                Array.Copy(array, temp, shift);
                Array.Copy(array, shift, array, 0, lengthArray - shift);
                Array.Copy(temp, 0, array, lengthArray - shift, shift);
            }
        }

        // Function to find the maximum even element at even indices
        public static int MaxEvenElementEvenIndex(int[] array, out int index)
        {
            index = -1;
            int max = int.MinValue;

            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] % 2 == 0 && array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }

            if (index == -1)
            {
                throw new invalid_argument("No even element found at even indices.");
            }

            return max;
        }

        static void Main(string[] args)
        {
            // Testing ProductEvenIndices
            float[] floatArray = { 1.5f, 2.3f, 4.5f, 6.7f, 8.9f };
            Console.WriteLine("Product of even indices: " + ProductEvenIndices(floatArray));

            // Testing LeftShifting
            Console.WriteLine("\nBefore shift:");
            foreach (var item in floatArray) Console.Write(item + " ");
            LeftShifting(floatArray, 2);
            Console.WriteLine("\nAfter shift:");
            foreach (var item in floatArray) Console.Write(item + " ");

            // Testing MaxEvenElementEvenIndex
            int[] intArray = { 3, 2, 4, 7, 6, 5, 8 };
            int index;
            int maxEven = MaxEvenElementEvenIndex(intArray, out index);
            Console.WriteLine($"\nMax even element at even index: {maxEven}, at index: {index}");
        }
    }
}
