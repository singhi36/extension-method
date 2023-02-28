
   using System;
namespace outOfPotential
    {
    class program
    {
        static void Main(string[] args)
        {
            string inputS = "Hello inder";
            int count = inputS.GetWordCount();

            Console.WriteLine("String value "+inputS);
            Console.WriteLine("Word count " + count);

        }
    }
        public static class ExtensionMethods
        {
            public static int GetWordCount(this string someData)
            {
                string[] stringArray = someData.Split(' ');
                int arrayLength = stringArray.Length;
                return arrayLength;
            }

        }
    }