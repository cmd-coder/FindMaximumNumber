using System;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            Generic<int> generic = new Generic<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            Generic<double> genericDouble = new Generic<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "111", "222", "333", "55", "999" };
            Generic<string> genericString = new Generic<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}
