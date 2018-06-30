using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class DataTypes
    {
        public static void DataTypeBool()
        {
            bool myBool = true;
            Console.WriteLine("DataTypBool: {0}", myBool);
        }
        public static void DataTypeByte()
        {
            byte myByte = 255;
            Console.WriteLine("DataTypByte: {0}", myByte);
        }
        public static void DataTypeChar()
        {
            // USE SINGLE QUOTES FOR CHAR
            char myChar = 'Z';
            Console.WriteLine("DataTypeChar: {0}", myChar);
            Console.WriteLine("DataTypeChar: Calling char.IsUpper: {0}", char.IsUpper(myChar));
            Console.WriteLine("DataTypeChar: Calling char.IsDigit: {0}", char.IsDigit(myChar));
            Console.WriteLine("DataTypeChar: Calling char.IsLetter: {0}", char.IsLetter(myChar));
            Console.WriteLine("DataTypeChar: Calling char.IsPunctuation: {0}", char.IsPunctuation(myChar));
            Console.WriteLine("DataTypeChar: Calling char.IsWhiteSpace: {0}", char.IsWhiteSpace(myChar));
            Console.WriteLine("DataTypeChar: Calling char.ToUpper: {0}", char.ToUpper(myChar));
            Console.WriteLine("DataTypeChar: Calling char.ToLower: {0}", char.ToLower(myChar));
        }
        public static void DataTypeDate()
        {

        }
        public static void DataTypeDecimal()
        {

        }
        public static void DataTypeDouble()
        {

        }
        public static void DataTypeInt()
        {
            int i = 10;
            Console.WriteLine("DataTypeInt{0}", i);
        }
        public static void DataTypeLong()
        {
            //long                64        -9BIG to 9BIG
            long myLong = 855444333222111;
            Console.WriteLine("DataTypeLong: {0}", myLong);
        }
        public static void DataTypeString()
        {
            string myString = "this is a string";
            Console.WriteLine("DataTypeInt{0}", myString);
            Console.WriteLine("Calling string.Trim: {0}", myString.Trim());
            Console.WriteLine("Calling string.ToUpper: {0}", myString.ToUpper());
            Console.WriteLine("Calling string.ToLower: {0}", myString.ToLower());
            Console.WriteLine("Calling string.IndexOf: {0}", myString.IndexOf("a"));
            Console.WriteLine("Calling string.LastIndexOf: {0}", myString.LastIndexOf("and"));
        }
        public static void DataTypeObject()
        {
            int i = 0;
            int iObj = new int();
            iObj = 0;
            Console.WriteLine("Object: iObj.GetType() = {0}", iObj.GetType());
            Console.WriteLine("Object: iObj.toString() = {0}", iObj.ToString());
            Console.WriteLine("Object: iObj.EqualstoString(i) = {0}", iObj.Equals(i));

            if(iObj is int)
            {
                //
            }
            else if (iObj is string)
            {

            }

            int j = (int)iObj;
            string intToString = iObj.ToString();




        }
    }
}


//Working with Integer Numbers
//byte                8        0 to 255
//sbyte                8        -128 to 127
//short                16        -32,768 to 32,767
//ushort                 16        0 to 65,535
//int                32        -2.1B to 2.1B
//uint                23        0 to 4.3B
//long                64        -9BIG to 9BIG
//ulong                64        16BIGBIG
//Floating Point Numbers(Base10 or Base2)
//float                0.0f        7 digits of precision
//double                0.0d        15-16 digits of precision( base 2 numbers)
//decimal        0.0m        28-29 digits of precision( base 10 numbers)
//Special Floating Point Values
//NaN Not a number
//PositveInfinity                0 < Infinity
//NegativeInfinity        0 > Infinity
//Double v.s.Decimal
//double                0.0d        15-16 digits of precision( base 2 numbers)
//decimal        0.0m        28-29 digits of precision( base 10 numbers)
