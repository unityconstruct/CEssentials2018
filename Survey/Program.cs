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
        }
    }
}
