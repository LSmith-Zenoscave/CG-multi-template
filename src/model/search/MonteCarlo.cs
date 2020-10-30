using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace template
{
    internal class MonteCarlo : Searcher
    {
        // Should be a full bitmask for eval repetitions before check.
        static int EVAL_REPS = 0xFF;

        Stopwatch sw = new Stopwatch();
        Random rand = new Random();
        public override List<Action> search(Game game, int timeout_ms)
        {
            sw.Restart();
            var actions = game.AvailableActions();
            var actionSets = new Dictionary<List<Action>, int>();
            foreach (var action in actions)
            {
                actionSets[action] = 0;
            }

            var evalCount = 0;

            do
            {
                var selectedAction = actions[rand.Next(actions.Count)];
                actionSets[selectedAction] += PlayAction(new Game(game), selectedAction);
                evalCount++;
            }
            while((evalCount & EVAL_REPS) > 0 || sw.ElapsedMilliseconds < timeout_ms - 10);
            
            List<Action> best = null;
            var bestScore = int.MinValue;
            foreach(var actionset in actionSets)
            {
                if (actionset.Value > bestScore)
                {
                    best = actionset.Key;
                    bestScore = actionset.Value;
                }
            }

            IO.Debug($"Evals: {evalCount} in {sw.ElapsedMilliseconds} ms");

            return best;
        }

        private int PlayAction(Game game, List<Action> selectedAction)
        {
            Game curr = game.Play(selectedAction);
            while (!curr.Over())
            {
                var actions = curr.AvailableActions();
                curr = curr.Play(actions[rand.Next(actions.Count)]);
            }

            return curr.Score();
        }
    }
}