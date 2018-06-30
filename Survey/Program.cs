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
            Basics.ConstantsAndEnumerations.Constants();
            Basics.ConstantsAndEnumerations.Enumerations();
        }
    }
}
