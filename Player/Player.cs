using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    //Facade pattern
    public class Player
    {
        private int hitPoints;
        private int levelScore;
        private int powerUp;

        private HitPoints _hitPoints;
        private LevelScore _levelScore;
        private PowerUp _powerUp;
        GunFactory gunFactory;
        Gun gun;

        private IState _state;

        private int highScoreState;

        public Player(int newHitPoints, int newLevelScore, int newPowerUp, IState state)
        {
            hitPoints = newHitPoints;
            levelScore = newLevelScore;
            powerUp = newPowerUp;

            _hitPoints = new HitPoints();
            _levelScore = new LevelScore();
            _powerUp = new PowerUp();

            this._state = state;
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

        public void getPlayerAGun(string gunName){
           
            gunFactory = new GunFactory(gunName);
            gun = gunFactory.createGun();
            Console.WriteLine("You’re dealing with " + gun.ShowDescription());
        }

        public void playerShoots(){
            Console.WriteLine(gun.Shoot());
        }

        public IState IState
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("Player's size: " + _state.GetType().Name);
            }
        }

        public void sizeRequest()
        {
            _state.changeSize(this);
        }

        public int HighScoreState
        {
            get { return highScoreState; }
            set
            {
                highScoreState = value;
                Console.WriteLine("High score: " + highScoreState);
            }
        }
        public HighScoreMemento showHighScore()
        {
            return (new HighScoreMemento(highScoreState));
        }

        public void saveHighScoreState(HighScoreMemento memento)
        {
            Console.WriteLine("Restoring high score...");
            HighScoreState = memento.HighScoreState;
        }
    }
}
