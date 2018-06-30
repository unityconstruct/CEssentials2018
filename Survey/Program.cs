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
            //Basics.StringEx.StringConcatenate();
            Basics.EvaluationsAndExpressions.IfThenElseEx();
            Basics.EvaluationsAndExpressions.AndOrEx();
            Basics.EvaluationsAndExpressions.PrefixPostfix();
            Basics.EvaluationsAndExpressions.TernaryOperatorEx();
            Basics.EvaluationsAndExpressions.OperatorPrecedence();
            Basics.EvaluationsAndExpressions.IsEvaluation();
            Basics.EvaluationsAndExpressions.SwitchStatement();

            Basics.ConstantsAndEnumerations.Constants();
            Basics.ConstantsAndEnumerations.Enumerations();

            Basics.Loops.LoopWhile();
            Basics.Loops.LoopDoWhile();            
            Basics.Loops.LoopFor();
            Basics.Loops.LoopForEach();
            Basics.Loops.LoopContinue();
            Basics.Loops.LoopBreak();

            Console.WriteLine("MethodReturnsInt: {0}", Basics.Methods.MethodReturnsInt());
            Console.WriteLine("MethodReturnsString: {0}", Basics.Methods.MethodReturnsString());
            Console.WriteLine("MethodReturnsBool: {0}", Basics.Methods.MethodReturnsBool());
            Basics.Methods.MethodCallsPrivate();
            Basics.Methods.MethodInputArgs(1,"myString");

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
    }
}
