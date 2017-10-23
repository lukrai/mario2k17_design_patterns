using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    //Facade pattern
    class HitPoints
    {
        public int points;
        public void increase(int hitPoints)
        {
            if (hitPoints < 100)
            {
                hitPoints++;
                Console.WriteLine("Hit points increased " + hitPoints);
            }
            points = hitPoints;
        }
        public void decrease(int hitPoints)
        {
            if (hitPoints > 1)
            {
                hitPoints--;
                Console.WriteLine("Hit points decreased " + hitPoints);
                points = hitPoints;
            }
            else
            {
                Console.WriteLine("Game Over.");
            }
        }
    }
}
