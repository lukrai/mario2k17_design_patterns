using System;

namespace Mario2k17
{
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
