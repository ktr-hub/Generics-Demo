using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring arrays
            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'A', 'B', 'C', 'D' };

            //Calling methods
            Console.WriteLine("Int Array elements :");
            toPrint(intArray);
            Console.WriteLine("Double Array elements :");
            toPrint(doubleArray);
            Console.WriteLine("Char Array elements :");
            toPrint(charArray);
        }
        //To print Int Array
        public static void toPrint(int[] inputArray)
        {
            foreach(int element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
        //To print Double Array
        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
        //To print Char Array
        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
