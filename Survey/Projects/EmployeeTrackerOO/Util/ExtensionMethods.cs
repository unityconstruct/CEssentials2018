using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO.Util
{
    public static class ExtensionMethods
    {
        // this extends the 'string' type
        // this is self-referencing
        // returns int
        public static int toInt(this string value)
        {
            return int.Parse(value);
        }
    }
}
