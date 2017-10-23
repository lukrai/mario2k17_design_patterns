using System;

namespace Mario2k17
{
    //Singleton pattern
    public class DatabaseConnect
    {
        private String connectionString;
        private String databaseName;
        private long userID;
        private long userScore;
        private static DatabaseConnect singletonInstance;
        private DatabaseConnect() {}
        private static object threadLock = new object();
        public static DatabaseConnect returnInstance()
        {
            lock(threadLock)
            {
                if(singletonInstance == null)
                {
                    singletonInstance = new DatabaseConnect();
                }
            }
            return singletonInstance;
        }
        
        public void updateScore()
        {
            Console.WriteLine("Score Updated");
        }
    }

    //Strategy pattern
    abstract class EnemyDifficulty
    {
        public abstract void addDifficulty();
    }

    //Strategy pattern
    class Easy : EnemyDifficulty
    {
        public override void addDifficulty()
        {
            Console.WriteLine("Called enemy with easy difficulty");
        }
    }

    //Strategy pattern
    class Hard : EnemyDifficulty
    {
        public override void addDifficulty()
        {
            Console.WriteLine("Called enemy with hard difficulty");
        }
    }

    //Strategy pattern
    class Enemy
    {
        private String name;
        private int damage;
        private int hitPoints;
        private EnemyDifficulty _enemyDifficulty;

        public void show() { }

        public Enemy(EnemyDifficulty difficulty)
        {
            this._enemyDifficulty = difficulty;
        }

        public void setEnemy()
        {
            _enemyDifficulty.addDifficulty();
        }
    }

    //Facade pattern
    class HitPoints
    {
        public int points;
        public void increase(int hitPoints)
        {
            if(hitPoints < 100)
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

    //Facade pattern
    class LevelScore
    {
        public void showAchievement()
        {
            Console.WriteLine("Level Up!");
        }
    }

    //Facade pattern
    class PowerUp
    {
        public int power;
        public void increase(int powerUp)
        {
            if(powerUp < 100)
            {
                powerUp += 10;
                Console.WriteLine("Power Up increased! " + powerUp);
            }
            power = powerUp;
        }
        public void decrease(int powerUp)
        {
            if(powerUp >= 10)
            {
                powerUp -= 10;
                Console.WriteLine("Power Up decreased... " + powerUp);
            }
            power = powerUp;
        }
    }

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
    class MarioApp
    {
        static void Main(string[] args)
        {
            DatabaseConnect database = DatabaseConnect.returnInstance();
            database.updateScore();
            Console.ReadKey();

            Enemy enemy;
            enemy = new Enemy(new Easy());
            enemy.setEnemy();
            enemy = new Enemy(new Hard());
            enemy.setEnemy();
            Console.ReadKey();

            Player player = new Player(100, 0, 0);
            player.playerGotPowerUp();
            player.playerReachedAchievement();
            player.playerGotHit();
            player.playerGotHit();
            player.playerGotPowerUp();
            player.playerGotPowerUp();
        }
    }
}
