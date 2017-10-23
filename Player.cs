using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    //Facade pattern
    class Player
    {
        private int hitPoints;
        private int levelScore;
        private int powerUp;

        private HitPoints _hitPoints;
        private LevelScore _levelScore;
        private PowerUp _powerUp;

        public Player(int newHitPoints, int newLevelScore, int newPowerUp)
        {
            hitPoints = newHitPoints;
            levelScore = newLevelScore;
            powerUp = newPowerUp;

            _hitPoints = new HitPoints();
            _levelScore = new LevelScore();
            _powerUp = new PowerUp();
        }

        public void playerGotHit()
        {
            Console.WriteLine("Player got hit");
            _hitPoints.decrease(hitPoints);
            hitPoints = _hitPoints.points;
            _powerUp.decrease(powerUp);
            powerUp = _powerUp.power;

        }
        public void playerGotPowerUp()
        {
            Console.WriteLine("Player got powered up!");
            _hitPoints.increase(hitPoints);
            hitPoints = _hitPoints.points;
            _powerUp.increase(powerUp);
            powerUp = _powerUp.power;
        }
        public void playerReachedAchievement()
        {
            Console.WriteLine("Player reached an achievement");
            _levelScore.showAchievement();
        }

    }
}
