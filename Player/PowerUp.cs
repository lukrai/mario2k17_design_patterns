using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    //Facade pattern
    class PowerUp
    {
        public int power;
        public void increase(int powerUp)
        {
            if (powerUp < 100)
            {
                powerUp += 10;
                Console.WriteLine("Power Up increased! " + powerUp);
            }
            power = powerUp;
        }
        public void decrease(int powerUp)
        {
            if (powerUp >= 10)
            {
                powerUp -= 10;
                Console.WriteLine("Power Up decreased... " + powerUp);
            }
            power = powerUp;
        }
    }
}
