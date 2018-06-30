using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class CharsAndStrings
    {
        public static string url = "http://www.unityconstruct.org";
        public static string strUrlTrim;

        public static void StringConcatenate()
        {
            Console.WriteLine("Using + is allowed, but not preferred," + " so use the inline method");
            Console.WriteLine("Use arguments inline then append string with the args like: arg0:{0}, arg1:{1}, arg2:{2}", "arg0", "arg1", "arg2");
        }

        public static void CharEvals()
        {
            // create array with various assignments, then use foreach loop for Console output
            char[] aOutputChars = new char[10];
            aOutputChars[0] = 'a';


            // output chars to console
            int cnt = 0;
            foreach (char a in aOutputChars)
            {
                Console.WriteLine("StringEvals: aOutputChars[{0}] =  {1}", cnt++, a);
            }



            char myChar = '8';
            // Do some character tests
            Console.WriteLine("Calling char.IsUpper: {0}", char.IsUpper(myChar));
            Console.WriteLine("Calling char.IsDigit: {0}", char.IsDigit(myChar));
            Console.WriteLine("Calling char.IsLetter: {0}", char.IsLetter(myChar));
            Console.WriteLine("Calling char.IsPunctuation: {0}", char.IsPunctuation(myChar));
            Console.WriteLine("Calling char.IsWhiteSpace: {0}", char.IsWhiteSpace(myChar));
            Console.WriteLine("Calling char.ToUpper: {0}", char.ToUpper(myChar));
            Console.WriteLine("Calling char.ToLower: {0}", char.ToLower(myChar));
            Console.WriteLine();




        }

        public static void StringEvals()
        {
            string str = "myString";
            Console.WriteLine("a String");
            Console.WriteLine("string with a \n line break");
            Console.WriteLine("c:\\temp\\userfile.txt");
            Console.WriteLine(@"c:\temp\userfile-escaped.txt");
            Console.WriteLine("String-ToLower(): " + str.ToLower());
            Console.WriteLine("String-ToUpper(): " + str.ToUpper());
            Console.WriteLine("String-ToString()" + str.Contains("my").ToString());
            Console.WriteLine("String-SubString-start: " + str.Substring(3));
            Console.WriteLine("String-SubString-start,length: " + str.Substring(3, 3));
            Console.WriteLine("String-Replace(ByChar) {0}", url.IndexOf("u"));
            Console.WriteLine("String-Trim: {0}", url.Trim());
            Console.WriteLine("String-IndexOf {0}", url.IndexOf("u"));
            Console.WriteLine("String-Trim: {0}", url.Trim());
            Console.WriteLine("String-Equals(object): {0}", url.Equals(str));
            Console.WriteLine("String-IndexOf: {0}", url.IndexOf("construct"));
            Console.WriteLine("Calling string.Trim: {0}", url.Trim());
            Console.WriteLine("Calling string.ToUpper: {0}", url.ToUpper());
            Console.WriteLine("Calling string.ToLower: {0}", url.ToLower());
            Console.WriteLine("Calling string.IndexOf: {0}", url.IndexOf("a"));
            Console.WriteLine("Calling string.LastIndexOf: {0}", url.LastIndexOf("and"));

            char[] aChars = { 'a', 'u', 'z' };
            Console.WriteLine("String-IndexOfAny: {0}", url.IndexOfAny(aChars));
        }

        public static void StringArrayForEachOutput()
        {
            // create array with various assignments, then use foreach loop for Console output
            string str = "myString";
            string[] aOutputStrings = new string[10];
            aOutputStrings[0] = "a String";
            aOutputStrings[1] = "string with a \n line break";
            aOutputStrings[2] = "c:\\temp\\userfile.txt";
            aOutputStrings[3] = @"c:\temp\userfile-escaped.txt";
            aOutputStrings[4] = "String-ToLower(): " + str.ToLower();
            aOutputStrings[5] = "String-ToUpper(): " + str.ToUpper();
            aOutputStrings[6] = "String-ToString()" + str.Contains("my").ToString();
            aOutputStrings[7] = "StirSubString-start: " + str.Substring(3);
            aOutputStrings[8] = "SubString-start,length: " + str.Substring(3, 3);

            // output strings to console
            int cnt = 0;
            foreach (string s in aOutputStrings)
            {
                Console.WriteLine("StringEvals: aOutputStrings[{0}] =  {1}", cnt++, s);
            }


        }

        public static void StringSpilts()
        {
            // splitting a url at '.'

            string[] aStringSplits = url.Split('.');
            int cnt = 0;

            Console.WriteLine("StringSplits..Splitting: {0}", url);
            foreach (string s in aStringSplits)
            {
                Console.WriteLine("StringSplits[0] =  {1}", cnt++, s);
            }
        }

        public static void StringReplace()
        {
            string strUrlReplace = url.Replace('.', '!');
            Console.WriteLine("StringReplace(ByChar) {0}", strUrlReplace);
        }

        public static void StringTrim()
        {
            strUrlTrim = url.TrimEnd('.');
            Console.WriteLine("StringReplace(ByChar) {0}", strUrlTrim);

            strUrlTrim = url.Trim('.');
            Console.WriteLine("StringReplace(ByChar) {0}", strUrlTrim);

            strUrlTrim = url.TrimStart('.');
            Console.WriteLine("StringReplace(ByChar) {0}", strUrlTrim);
        }

        public static void StringBuilderEx()
        {
            StringBuilder sb = new StringBuilder();
            for(int c = 0; c < 30; c++)
            {
                sb.Append("--" + c + "--");
            }
            Console.WriteLine("StringBuilder length = {0}", sb.Length);
            Console.WriteLine(sb); 


        }


        
    }
}
