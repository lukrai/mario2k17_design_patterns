using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class BigState : IState
    {
        public void changeSize(Player player)
        {
            player.IState = new SmallState();
        }
    }
}
