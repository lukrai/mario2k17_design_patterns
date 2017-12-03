using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    class Day : DayCycle
    {
        public override void showDayTime(int time)
        {
            if (time >= 12 && time < 18)
            {
                Console.WriteLine("It's Day now!");
            }
            else if (successor != null)
            {
                successor.showDayTime(time);
            }
        }
    }
}
