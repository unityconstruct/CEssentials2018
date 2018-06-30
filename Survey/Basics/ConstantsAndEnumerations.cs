using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class ConstantsAndEnumerations
    {


        enum Temperatures : int
        {
            REALLYCOLD,
            FREEZING = 32,
            SUBZERO = -32,
            LUKEWARM = 65,
            HOT = 105,
            BOILING = 212

        }

        public static void Constants()
        {
            const int FREEZING = 32;
            int temp = 99;
            String freezing;
            if(temp < FREEZING)
            {
                freezing = "IS";
            } else
            {
                freezing = "IS NOT";
            }

            Console.WriteLine("Temp = {0} and {1} Freezing", temp, freezing);
        }

        public static void Enumerations()
        {
            // MUST TYPECAST ENUMS to desired DataType
            int myTemp = 45;
            if (myTemp > (int)Temperatures.FREEZING)
            {
                Console.WriteLine("myTemp({0}) is NOT FREEZING", myTemp);
            }
        }


    }
}
