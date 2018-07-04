using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.Survey
{
    class Stats
    {
        // to add/activate the listener add to a method
        // once this method is called, anytime the 'Triggered' is encountered, 
        //   the HasTriggered() method is called
        public void Start()
        {
            Survey.Triggered += HasTriggered;
        }

        void HasTriggered()
        {
            Console.WriteLine("Survey Triggered, run stats");
        }
    }
}
