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

            //Calling methods for UC-2
            Console.WriteLine("Int Array elements :");
            toPrint<int>(intArray);
            Console.WriteLine("Double Array elements :");
            toPrint<double>(doubleArray);
            Console.WriteLine("Char Array elements :");
            toPrint<char>(charArray);


        }
        //To print Int Array
        public static void toPrint<T>(T[] inputArray)
        {
            foreach(T element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
        
    }
}
