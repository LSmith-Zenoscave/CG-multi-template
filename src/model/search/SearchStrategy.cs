using System.Collections.Generic;

namespace template
{
    internal class SearchStrategy<S>: BaseStrategy
        where S : Searcher, new()
    {
        public override List<Action> solve(Game game, int timeout_ms)
        {
            var sovler = SearchFactory.getSearcher<S>();
            return sovler.search(game, timeout_ms);
        }
    }
}