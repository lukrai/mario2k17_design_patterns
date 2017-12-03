using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class SmallState : IState
    {
        public void changeSize(Player player)
        {
            player.IState = new BigState();
        }
    }
}
