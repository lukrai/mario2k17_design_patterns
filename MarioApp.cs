using Mario2k17.Map;
using System;

namespace Mario2k17
{
    class MarioApp
    {
        static void Main(string[] args)
        {
            //Singleton
            DatabaseConnect database = DatabaseConnect.returnInstance();
            database.updateScore();
            Console.ReadKey();
            //Chain of Resp.
            DayCycle d1 = new Morning();
            DayCycle d2 = new Day();
            DayCycle d3 = new Evening();
            DayCycle d4 = new Night();
            d1.setNextChain(d2);
            d2.setNextChain(d3);
            d3.setNextChain(d4);

            int[] times = { 11 };
            foreach (int time in times)
            {
                d1.showDayTime(time);
            }
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
            //Strategy
            Enemy enemy;
            enemy = new Enemy(new Easy());
            enemy.setEnemy();
            enemy = new Enemy(new Hard());
            enemy.setEnemy();
            Console.ReadKey();

            Player player = new Player(100, 0, 0, new SmallState());
            //Facade
            player.playerGotPowerUp();
            player.playerReachedAchievement();
            //State
            player.sizeRequest();
            Console.ReadKey();
            //Facade
            player.playerGotHit();
            player.playerGotHit();
            player.playerGotPowerUp();
            player.playerGotPowerUp();
            player.sizeRequest();
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
            Console.ReadKey();

            //Memento
            player.HighScoreState = 52;
            Caretaker c = new Caretaker();
            c.HighScoreMemento = player.showHighScore();
            player.HighScoreState = 25;
            player.saveHighScoreState(c.HighScoreMemento);
            
            //Proxy
            enemy.showEnemyDeath();

            IDefenceMediator mediator = new DefenceMediator();
		
            Building tower1 = new Tower(mediator);
            Building tower2 = new Tower(mediator);
            Building tower3 = new Tower(mediator);
            
            mediator.AddBuildng(tower1);
            mediator.AddBuildng(tower2);
            mediator.AddBuildng(tower3);
            
            tower1.SendSignal("Player spoted!");
            

        
        }
    }
}
