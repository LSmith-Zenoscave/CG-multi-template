using System;
using System.Collections.Generic;

namespace template
{
    abstract internal class BaseStrategy
    {
        abstract public List<Action> solve(Game game, int timeout_ms);
    }
}