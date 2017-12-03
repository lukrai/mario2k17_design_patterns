using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class HighScoreMemento
    {
        private int highScoreState;
        public HighScoreMemento(int state)
        {
            this.highScoreState = state;
        }
        public int HighScoreState
        {
            get { return highScoreState; }
        }
    }
}
