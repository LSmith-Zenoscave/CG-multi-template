using System;

namespace template
{
    class Solution
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var strategy = new BaseStrategy();

            game.init();

            while(true)
            {
                game.update();
                var actions = strategy.solve(game, game.Turn == 1 ? 1000 : 100);
                IO.WriteLine(actions);
            }
        }
    }
}
