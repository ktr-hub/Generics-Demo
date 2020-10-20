using System;

namespace GenericsDemo
{
    public class PrintArray<Type>
    {
        private Type[] inputArray;
        public PrintArray(Type[] inputArray)
        {
            this.inputArray = inputArray;
        }

        //To print Any Array
        public void toPrint()
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            //Declaring arrays
            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'A', 'B', 'C', 'D' };

            //Calling methods for UC-3

            Console.WriteLine("Int Array elements :");
            new PrintArray<int>(intArray).toPrint();
            Console.WriteLine("Double Array elements :");
            new PrintArray<double>(doubleArray).toPrint();
            Console.WriteLine("Char Array elements :");
            new PrintArray<char>(charArray).toPrint();
        }
    }
}