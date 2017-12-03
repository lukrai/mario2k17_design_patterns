using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    class Caretaker
    {
        private HighScoreMemento _memento;
        public HighScoreMemento HighScoreMemento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
