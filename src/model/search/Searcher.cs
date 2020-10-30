using System;
using System.Collections.Generic;

namespace template
{
    internal abstract class Searcher
    {
        internal Searcher() {}

        public abstract List<Action> search(Game game, int timeout_ms);
    }
}