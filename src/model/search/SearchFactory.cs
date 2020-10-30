using System;
using System.Collections.Generic;

namespace template
{
    internal class SearchFactory
    {
        private static Dictionary<Type, Searcher> instances = new Dictionary<Type, Searcher>();

        public static S getSearcher<S>() where S : Searcher, new()
        {
            if (!instances.ContainsKey(typeof(S)))
            {
                instances[typeof(S)] = new S();
            }

            return (S)instances[typeof(S)];
        }
    }
}