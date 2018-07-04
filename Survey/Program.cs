using System;


namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            //Passcode.AuthPasscode();
            //Console.ReadLine();
        }


        public static void Run()
        {
            Survey_Runner();

            //EmployeeTracker_Runner();

            //ValueAndReferenceTypesAndMemory_Runner();

            //ConsoleWriteAndReadLine_Runner();

            //EvaluationsAndExpressions_Runner();

            //ConstantsAndEnumerations_Runner();

            //Loops_Runner();

            //Collections_Runner();

            //Methods_Runner();

            //DataTypes_Runner();

            //CharsAndStrings_Runner();

            //Scope_Runner();

            //Book_Runner();

            //ClassesAndSubClasses_Runner();

            //DBConnections_Runner();


        }

        private static void ValueAndReferenceTypesAndMemory_Runner()
        {
            Basics.ValueAndReferenceTypesAndMemory.ValueTypes();
            Basics.ValueAndReferenceTypesAndMemory.ValueTypesWithOut();
            Basics.ValueAndReferenceTypesAndMemory.ValueTypesWithRef();
            //Basics.ValueAndReferenceTypesAndMemory.ReferenceTypes();
        }

        private static void EmployeeTracker_Runner()
        {
            //Projects.EmployeeScoreTracker.ProcessEmployees();
            //Projects.EmployeeScoreTracker.ProcessEmployeesWithList();

            Projects.EmployeeTrackerOO.EmployeeTracker.ProcessEmployeesWithList();

            //Projects.EmployeeTrackerOO.EmployeeTracker.Import();
        }

        private static void Survey_Runner()
        {
            Projects.Survey.Survey.AskSurvey();
        }

        private static void ConsoleWriteAndReadLine_Runner()
        {
            Basics.WriteAndReadLine.ConsoleWriteLine();
            Basics.WriteAndReadLine.ConsoleReadLine();
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

        private static void Collections_Runner()
        {
            Basics.Collections.ArraySingleDimension();
            Basics.Collections.ArrayChar();
            Basics.Collections.ArrayStrings();
            Basics.Collections.ArrayInt();
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

        private static void DBConnections_Runner()
        {
            DB.DBConnections.MySQLConxAndQuery();
        }

        private static void ClassesAndSubClasses_Runner()
        {
            //Static access methods
            Console.WriteLine("------BaseClass Static Method Call----------");
            Basics.BaseClass.StaticPrintOut();

            Console.WriteLine("------SubClass Static Method Calls----------");
            Basics.BaseSubClass.StaticPrintOut();
            Basics.BaseSubClass.StaticPrintOutSubClass();

            //Instantiated methods
            Console.WriteLine("------Instantiated SubClass &  Calls----------");
            // calls BaseClass contructure, THEN SubClass Constructor
            Basics.BaseSubClass sc = new Basics.BaseSubClass();
            sc.InstancePrintOutSubClass();
            sc.InstancePrintOut();
        }

    }
}
