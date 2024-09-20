using System;
using System.IO;
using System.Text;
using System.Runtime.CompilerServices;

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
        static int[] GenerateArray(int length)
        {
            int Min = -100;
            int Max = 100;

            int[] arr = new int[length];
            Random randNum = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }
            return arr;
        }
        static int GenerateRand(int Min, int Max)
        {
            //int Min = -2;
            //int Max = 2;

            int rand;
            Random randn = new Random();
            rand = randn.Next(Min, Max);
            
            return rand;
        }

        static float[] GenerateArrayfloat(int length)
        {
            int Min = -100;
            int Max = 100;

            float[] arr = new float[length];
            Random randNum = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }
            return arr;
        }

        public static int[] SumArray(int[] a, int[] b)
        {

            if (a.Length != b.Length)
            {
                Console.WriteLine(" Length a != Length b");
                throw new invalid_argument("Разные длины массивов!");
            }

            int[] sums = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                sums[i] = a[i] + b[i];
            }
            return sums;
        }
        public static void LeftShifting(float[] array, int shift)
        {
            int LengthArray = array.Length;
            if (LengthArray == 0)
            {
                Console.WriteLine("Исходный массив пустой");
                return; 
            }  

            shift = shift % LengthArray;
            if (shift == 0) 
            {
                Console.WriteLine("Cмещение 0");
                throw new invalid_argument("Cмещение 0!");
            } 

            float[] temp = new float[Math.Abs(shift)];
            
            if (shift < 0)
            {
                shift = Math.Abs(shift);
                Array.Copy(array, LengthArray - shift, temp, 0, shift);

                Array.Copy(array, 0, array, shift, LengthArray - shift);

                Array.Copy(temp, 0, array, 0, shift);
                
            }
            else
            {
                Array.Copy(array, temp, shift);

                Array.Copy(array, shift, array, 0, LengthArray - shift);

                Array.Copy(temp, 0, array, LengthArray - shift, shift);
            }    
        }

        public static int FindSubsequence(int[] vec, int[] seq)
        {
            int vecLength = vec.Length;
            int seqLength = seq.Length;

            if (seqLength > vecLength)
                return -1;

            for (int i = 0; i <= vecLength - seqLength; i++)
            {
                bool found = true;
                for (int j = 0; j < seqLength; j++)
                {
                    if (vec[i + j] != seq[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    return i;
                }
                else
                {
                  //  throw new invalid_argument("Cмещение 0!");
                }
                    
            }

            return -1;
        }

        public static int[] CreatingSubstring(int[] vec)
        {
            int f1 = GenerateRand(0, 20);
            int[] seq;
            int lengthvec = GenerateRand(0, vec.Length - 1);
            if (f1 > 10)
            {
                int lengthvec1 = GenerateRand(lengthvec, vec.Length);

                //Console.Write("\n{0} {1}\n", lengthvec, lengthvec1);

                seq = new int[lengthvec1 - lengthvec];
                Array.Copy(vec, lengthvec, seq, 0, lengthvec1 - lengthvec);
            }
            else
            {
                seq = new int[lengthvec];
                seq = GenerateArray(lengthvec);
            }
            return seq;
        }

        static void Main(string[] args)
        {
            //1
            Console.WriteLine("//1\n");
            int[] a = GenerateArray(10);
            int[] b = GenerateArray(10);
            int[] c = SumArray(a, b);
            Console.WriteLine("a");
            
            foreach (int i in a)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("b");
            
            foreach (int i in b)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("sum");
            
            foreach (int i in c)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");



            //2
            Console.WriteLine("//2\n");
            float[] d = GenerateArrayfloat(10);
            
            int shift = GenerateRand(-2,2);
            
            Console.Write("shift = {0}\n", shift);
            Console.WriteLine("d Before\n");
            foreach (int i in d)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");

            LeftShifting(d, shift);

            Console.WriteLine("\nd After for shifting\n");
            foreach (int i in d)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");
            
            
            //3
            Console.WriteLine("//3\n");
            int[] vec = GenerateArray(30);
            Console.WriteLine("vec\n");
            foreach (int i in vec)
            {
                Console.Write("{0} ", i);
            }
            
            
            int[] seq = CreatingSubstring(vec);
            Console.WriteLine("\nseq(substring of vec)\n");
            foreach (int i in seq)
            {
                Console.Write("{0} ", i);
            }
            
            Console.WriteLine("\n");
            int find = FindSubsequence(vec, seq);
            Console.Write("found index substring: {0} ", find);
        }

        
    }
}