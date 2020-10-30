using System;
using System.Collections.Generic;

namespace template
{
    class IO
    {
        static readonly bool SHOW_INPUT_DEBUG = true;
        static readonly string ACTION_DELIM = "; ";
        public static void Debug(string line) => Console.Error.WriteLine(line);

        public static void WriteLine(List<Action> actions) => Console.WriteLine(String.Join(ACTION_DELIM, actions));
        public static string ReadLine() {
            var line = Console.ReadLine();
            if (SHOW_INPUT_DEBUG) Debug(line);
            return line;
        }
    }

    static class StringExtension
    {
        public static int[] AsIntegers(this string input)
        {
            var words = input.Split();
            int[] vals = new int[words.Length];
            int idx = 0;
            foreach (var word in words)
            {
                vals[idx++] = int.Parse(word);
            }
            return vals;
        }
    }
}
