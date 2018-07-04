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
            Console.WriteLine("ArrayStrings:  aString[0] = \"zero\" = {0}", aString[0]);
        }

        public static void ArrayInt()
        {
            int[] scoreArray = new int[10];
            scoreArray[0] = 100;
            scoreArray[1] = 10;
            scoreArray[2] = 20;
            scoreArray[3] = 30;
            scoreArray[4] = 40;
            scoreArray[5] = 50;
            scoreArray[6] = 60;
            scoreArray[7] = 70;
            scoreArray[8] = 80;
            scoreArray[9] = 90;

            int counter = 0;
            foreach(int i in scoreArray)
            {
                Console.WriteLine("ArrayInt: scoreArray[{0}] = {1}", counter++,i);
            }
        }

        public static void ArrayAssignedAtDeclaration()
        {
            int counter = 0;
            int[] iArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach(int i in iArray)
            {
                Console.WriteLine("ArrayAssignedAtDeclaration: iArray[{0}] = {1}", counter++, i);
            }
        }
     
        public static void ListInt()
        {
            //
        }

        public static void ListString()
        {
            //
        }

        public static void ListBoolean()
        {
            //
        }





    }
}
