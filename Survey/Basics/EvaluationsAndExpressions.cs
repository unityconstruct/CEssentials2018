using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class EvaluationsAndExpressions
    {
        public static int integer1 = 1;
        public static int integer2 = 2;
        public static string string1 = "a";
        public static string string2 = "b";

        public static void IfThenElseEx()
        {
            if (integer1 == integer2) // equals
            {
                Console.WriteLine("a equals b");
            } else if ( integer1 != integer2) // NOT equals
            {
                Console.WriteLine("a not equals b");
            } else
            {
                Console.WriteLine("never called");
            }
        }

        public static void AndOrEx()
        {
            // OR , ||
            if ((integer1 == integer2) || (integer1 != integer2))
            {
                Console.WriteLine("(a ==b ) || (a != b) : Always called");
            }
            // AND,  &&
            if ((integer1 == integer2) && (integer1 != integer2))
            {
                Console.WriteLine("(a ==b ) && (a != b) : Never called");
            }
        }

        public static void OperatorsEx()
        {
            // ==
            if (string1 == string2)
            {
                Console.WriteLine("if (string1 == string2)");
            }
            // !=
            if (string1 != string2)
            {
                Console.WriteLine("if (string1 != string2)");
            }
            // <
            if (integer1 < integer2)
            {
                Console.WriteLine("if (integer1 < integer2)");
            }
            // <=
            if (integer1 <= integer2)
            {
                Console.WriteLine("if (integer1 <= integer2)");
            }

            // >
            if (integer1 > integer2)
            {
                Console.WriteLine("if (integer1 > integer2)");
            }

            // >=
            if (integer1 >= integer2)
            {
                Console.WriteLine("if (integer1 >= integer2)");
            }

            // !true
            if (!true)
            {
                Console.WriteLine("if (!true){0}", !true);
            }

            // !false
            if (!false)
            {
                Console.WriteLine("if (!false){0}", !false);
            }
        }

        public static void PrefixPostfix()
        {
            int counter = 10;

            for (int i = 1; i<counter; i++)
            {
                Console.WriteLine("i = {0}", i);
            }

            int j = 1;
            while ( j < counter){
                Console.WriteLine("j = {0}", j);
                j++;
            }

            int k = 1;
            do
            {
                Console.WriteLine("k = {0}", k);
                k++;
            } while (k < counter);

            k = 0;
            Console.WriteLine("---------k = 0---------");
            Console.WriteLine("k++ = {0}", k++);
            Console.WriteLine("k++ = {0}", k++);
            k = 0;
            Console.WriteLine("---------k = 0---------");
            Console.WriteLine("++k = {0}", ++k);
            Console.WriteLine("++k = {0}", ++k);

            k = 5;
            Console.WriteLine("---------k = 5---------");
            Console.WriteLine("k-- = {0}", k--);
            Console.WriteLine("k-- = {0}", k--);
            k = 5;
            Console.WriteLine("---------k = 5---------");
            Console.WriteLine("--k = {0}", --k);
            Console.WriteLine("--k = {0}", --k);
        }

        public static void TernaryOperatorEx()
        {
            bool b = (string1 != string2) ? true : false;
            Console.WriteLine("ternary....(string1 != string2) is {0}", b);
            //is the same as

            if (string1 != string2)
            {
                b = true;
            } else
            {
                b = false;
            }
            Console.WriteLine("If/Then/Else....(string1 != string2) is {0}", b);
        }

        public static void OperatorPrecedence()
        {
            // * / %
            double result;

            Console.WriteLine("integer1 = {0}, integer2 = {1}", integer1, integer2);

            result = integer1 * integer2 + 100;
            Console.WriteLine("integer1 * integer2 + 100 = {0}", result);

            result = 100 + integer1 * integer2;
            Console.WriteLine("100 + integer1 * integer2 = {0}", result);

            result = integer1 / integer2 - 100;
            Console.WriteLine("integer1 / integer2 - 100 = {0}", result);

            result = 100 - integer1 / integer2;
            Console.WriteLine("100 - integer1 / integer2 = {0}", result);


            result = integer1 % integer2 + 100;
            Console.WriteLine("integer1 % integer2 + 100 = {0}", result);

            result = 100 + integer1 % integer2;
            Console.WriteLine("100 + integer1 % integer2 = {0}", result);
        }

        public static void IsEvaluation()
        {
            // if type is String
            if (string2 is Object)
            {
                Console.WriteLine("if (string is Object) = true");
            } else
            {
                Console.WriteLine("if (string is Object = false)");
            }
        }

        public static void AsEvaluation()
        {
            //PENDING
            //void myFunctions(object obj)
            //{
            //    // if type is Employee
            //    if (obj is Employee)
            //    {
            //        // not clear on the purpose????
            //        Employee emp = obj as Employee; // null if can’t be done
            //        string name = emp.FirstName;
            //    }
            //}
        }

        public static void OperatorPrecedenceEx()
        {
            // PENDING


            // * / %

            // + -
            
            // < > <= => is as

            // == =!

            // AND &&

            // OR ||

            // Ternary ? :

            // Assignment  = *= %= += -=


        }
    }
}
