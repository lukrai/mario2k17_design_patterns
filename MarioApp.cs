using Mario2k17.Map;
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

            PipeGenerator pipeGenerator = new PipeGenerator();
            pipeGenerator.generateDongion();
            pipeGenerator.generateExit();
            pipeGenerator.generatePrizes();
            Pipe pipe = null;
            pipe = pipeGenerator.generatePipe();
            
            Console.ReadKey();
            GenerateGround generateGround = new GenerateGround(pipe);
            
            generateGround.GeneretaGround();
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
            //Gun factory
            Console.ReadKey();
            player.getPlayerAGun("Ak47");
            player.playerShoots();
            player.getPlayerAGun("Deagle");
            player.playerShoots();
            player.getPlayerAGun("Machine");
            player.playerShoots();
            //Enemies and BossAdapter
            enemy.setEnemyAttacker(new Turtle());
            enemy.showEnemyAttacker();
            enemy.setEnemyAttacker(new BossAdapter(new Boss()));
            enemy.showEnemyAttacker();
            //Bridge
            CollectibleController ringController = new RingController(new Ring(5));
            ringController.FirstMethod(5);
            ringController.SecondMethod();

            CollectibleController crownController = new CrownController(new Crown(10));
            crownController.FirstMethod(10);
            crownController.SecondMethod();
        
        }
    }
}
