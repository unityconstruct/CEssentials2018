using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class Loops
    {

        public static void LoopWhile()
        {
            int i = 1;
            while (i < 10)
            {
                Console.WriteLine("While Loop: i ={0}", i);
                i++;
            }
        }

        public static void LoopDoWhile()
        {
            int i = 1;
            do
            {
                Console.WriteLine("Do While Loop: i ={0}", i);
                i++;
            } while (i < 10);
        }

        public static void LoopFor()
        {
            for(int i = 1; i<10; i++)
            {
                Console.WriteLine("For Loop: i ={0}", i);
            }
        }

        public static void LoopForEach()
        {
            int[] intArray = new int[4];
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;

            int counter = 0;
            foreach (int i in intArray)
            {
                Console.WriteLine("ForEach Loop Array [ {0} ] = {1}",counter++, intArray[i - 1]);
            }
            //PENDING
        }

        public static void LoopContinue()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i > 3)
                {
                    Console.WriteLine("LoopContinue i={0}..Continuing > 3", i);
                    continue;
                }
            }
        }

        public static void LoopBreak()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i > 3)
                {
                    Console.WriteLine("LoopBreak i={0}..Breaking > 3", i);
                    break;
                    Console.WriteLine("LoopBreak i={0}..Breaking > 3--AFTER BREAK", i);
                }
            }


        }

    }
}
