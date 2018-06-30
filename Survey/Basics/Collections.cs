using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class Collections
    {

        public static void ArraySingleDimension()
        {
            int intValue;
            intValue = 1;

            // creates a single dimensional array
            int[] intArray = new int[4];
            int[] intArrayAssignedValues = { 100, 200, 300, 400 };

            foreach(int i in intArrayAssignedValues)
            {
                Console.WriteLine("ArraySingleDimension: intArray[{0}] = {1}.", i, intValue);
            }
        }

        public static void ArrayChar()
        {
            //char[] aChars = new char[4];
            char[] aChars =  { 'a', 'b', 'c', 'd'};
            
            int cnt = 0;
            foreach ( char c in aChars)
            {
                Console.WriteLine("ArrayChar: aChars[{0}] = {1}.", cnt, aChars[cnt++]);
            }
        }

        public static void ArrayStrings()
        {

            string[] aString = new string[10];
            int cnt = 0;
            aString[0] = "zero";

            
            
        }

    }
}
