using System;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Checking. Find max Number. Numbers are: 11, 22 and 33.");
            int outputInteger = Generic.MaximumNumber<int>(11, 22, 33);
            Console.WriteLine(outputInteger);

            Console.WriteLine("Float Number Checking. Find max Number. Numbers are: 11.1, 22.2 and 33.3.");
            float outputFloat = Generic.MaximumNumber<float>(11.1f, 22.2f, 33.3f);
            Console.WriteLine(outputFloat);

            Console.WriteLine("Float Number Checking. Find max Number. Numbers are: \"11\", \"22\" and \"33\".");
            string outputString=Generic.MaximumNumber<string>("11", "22", "33");
            Console.WriteLine(outputString);
        }
    }
}
