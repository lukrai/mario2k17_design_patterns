using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    class Evening : DayCycle
    {
        public override void showDayTime(int time)
        {
            if (time >= 18 && time < 24)
            {
                Console.WriteLine("It's Evening now!");
            }
            else if (successor != null)
            {
                successor.showDayTime(time);
            }
        }
    }
}
