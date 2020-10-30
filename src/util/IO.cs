using System;
using System.Collections.Generic;

namespace template
{
    class IO
    {
        static readonly string ACTION_DELIM = "; ";

        public static void WriteLine(List<Action> actions)
        {
            Console.WriteLine(String.Join(ACTION_DELIM, actions));
        }
    }
}
