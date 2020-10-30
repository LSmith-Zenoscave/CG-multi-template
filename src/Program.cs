using System;

namespace template
{
    class Solution
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var searcher = new SearchStrategy<MonteCarlo>();

            game.init();

            while(true)
            {
                game.update();
                var actions = searcher.solve(game, game.Turn == 1 ? 1000 : 100);
                IO.WriteLine(actions);
            }
        }
    }
}
