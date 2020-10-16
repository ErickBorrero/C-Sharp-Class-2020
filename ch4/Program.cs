using System;

namespace ch4
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            Console.WriteLine("*******Fun With Arrays*******");
            AddNumbers(3, 5 , out answer);
            System.Console.WriteLine(answer);
        }
        static void SimpleArrays()
        {
            System.Console.WriteLine();
            int[] myInts = new int[3];
            string[] booksOnDotNet = new string[100];
            myInts[2] = 32;

            foreach (var item in booksOnDotNet)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine(myInts[2]);
        }
        static void ArrayInitialization()
        {
            System.Console.WriteLine("**Array Initialization**");

            string[] stringArray = new string[] {"one", "two", "three"};

            System.Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            bool[] boolArray = {false, false, false};
            System.Console.WriteLine("boolArray has {0} elements", boolArray.Length);
        }
        static void MoreSystemStuff()
        {
            int[] numArray = new int[10];
            int num = 0;
            foreach (var item in numArray)
            {
                numArray[num] = num + 1;
                num++;
            }
            {
                
            }
            // for (int i = 0; i < numArray.length; i++)
            // {
            //     Index idx = i;
            //     System.Console.WriteLine(numArray[idx]);
            // }
        }
        static void AddNumbers(int x, int y, out int result)
        {
            result = x + y;
        }
    }
}
