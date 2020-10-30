using System;
using System.Collections.Generic;

namespace template
{
    internal class Game
    {
        public int Turn = 0;

        public Game()
        {
            throw new NotImplementedException();
        }

        public Game(Game game)
        {
            throw new NotImplementedException();
        }

        public void init()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            Turn++;
            throw new NotImplementedException();
        }

        internal List<List<Action>> AvailableActions()
        {
            throw new NotImplementedException();
        }

        internal Game Play(List<Action> selectedAction)
        {
            throw new NotImplementedException();
        }

        internal bool Over()
        {
            throw new NotImplementedException();
        }

        internal int Score()
        {
            throw new NotImplementedException();
        }
    }
}