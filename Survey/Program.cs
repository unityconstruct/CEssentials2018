using System;
using Basics;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Survey.AskSurvey();
            //Passcode.AuthPasscode();
            Run();
        }

        public static void Run()
        {
            //EvaluationsAndExpressions_Runner();

            //ConstantsAndEnumerations_Runner();

            //Loops_Runner();

            //Methods_Runner();

            //DataTypes_Runner();

            //CharsAndStrings_Runner();

            //Scope_Runner();

            Book_Runner();

        }

        private static void Book_Runner()
        {
            Basics.Book b = new Basics.Book();
            b.Title = "New Book Title";
            b.Author = "ME MAN!";
            b.UpateTime = "June30,2018";

            Console.WriteLine(b.Title);
            Console.WriteLine(b.Author);
            Console.WriteLine(b.id);
        }

        private static void DataTypes_Runner()
        {
            Basics.DataTypes.DataTypeBool();
            //Basics.DataTypes.DataTypeByte();
            //Basics.DataTypes.DataTypeChar();
            //Basics.DataTypes.DataTypeDate();
            //Basics.DataTypes.DataTypeDecimal();
            //Basics.DataTypes.DataTypeDouble();
            //Basics.DataTypes.DataTypeInt();
            Basics.DataTypes.DataTypeLong();
            //Basics.DataTypes.DataTypeObject();
            //Basics.DataTypes.DataTypeString();
        }

        private static void Methods_Runner()
        {
            Console.WriteLine("MethodReturnsInt: {0}", Basics.Methods.MethodReturnsInt());
            Console.WriteLine("MethodReturnsString: {0}", Basics.Methods.MethodReturnsString());
            Console.WriteLine("MethodReturnsBool: {0}", Basics.Methods.MethodReturnsBool());
            Basics.Methods.MethodCallsPrivate();
            Basics.Methods.MethodInputArgs(1, "myString");
        }

        private static void Loops_Runner()
        {
            Basics.Loops.LoopWhile();
            Basics.Loops.LoopDoWhile();
            Basics.Loops.LoopFor();
            Basics.Loops.LoopForEach();
            Basics.Loops.LoopContinue();
            Basics.Loops.LoopBreak();
        }

        private static void ConstantsAndEnumerations_Runner()
        {
            Basics.ConstantsAndEnumerations.Constants();
            Basics.ConstantsAndEnumerations.Enumerations();
        }

        private static void EvaluationsAndExpressions_Runner()
        {
            //Basics.StringEx.StringConcatenate();
            Basics.EvaluationsAndExpressions.IfThenElseEx();
            Basics.EvaluationsAndExpressions.AndOrEx();
            Basics.EvaluationsAndExpressions.PrefixPostfix();
            Basics.EvaluationsAndExpressions.TernaryOperatorEx();
            Basics.EvaluationsAndExpressions.OperatorPrecedence();
            Basics.EvaluationsAndExpressions.IsEvaluation();
            Basics.EvaluationsAndExpressions.SwitchStatement();
        }

        private static void CharsAndStrings_Runner()
        {
            Basics.CharsAndStrings.StringConcatenate();
            Basics.CharsAndStrings.CharEvals();

            Basics.Collections.ArrayChar();

            Basics.CharsAndStrings.StringEvals();
            Basics.CharsAndStrings.CharEvals();
            Basics.CharsAndStrings.StringSpilts();
            Basics.CharsAndStrings.StringArrayForEachOutput();
            Basics.CharsAndStrings.StringBuilderEx();


        }

        private static void Scope_Runner()
        {
            Basics.Scope.ScopePublic();
            Console.WriteLine("Scope.strPublic = {0}", Basics.Scope.strPublic);
            Console.WriteLine("Scope.intPublic = {0}",Basics.Scope.intPublic);

            // calls methods to change the private fields of the Scope class
            Console.WriteLine("Scope.GetIntPrivate = {0}", Basics.Scope.GetIntPrivate());
            Console.WriteLine("Scope.GetStringPrivate = {0}", Basics.Scope.GetStringPrivate());
            Basics.Scope.SetIntPrivate(99);
            Basics.Scope.SetStringPrivate("NEW STRING SET");
            Console.WriteLine("Scope.SetIntPrivate = {0}", Basics.Scope.GetIntPrivate());
            Console.WriteLine("Scope.SetStringPrivate = {0}", Basics.Scope.GetStringPrivate());

        }



    }
}
