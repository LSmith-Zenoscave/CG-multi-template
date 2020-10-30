using System;

namespace template
{
    internal class Action
    {
        // Action Types

        // Action Data
        public int Type;

        public Action(int type)
        {
            Type = type;
        }


        public override string ToString()
        {
            switch (Type)
            {
                default:
                    return "UNKOWN_ACTION";
            }
        }
    }
}
