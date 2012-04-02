using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tanks
{
    class Model
    {
        int collectedApples;
        int sizeField;
        int amountTanks;
        int amountApples;
        public int speedGame;
        public GameStatus gameStatus;
        public Wall wall;
        List<Tank> tanks;
        List<Apple> apples;
        Packman packman;
        List<FireTank> fireTank;
        public List<FireTank> FireTank
        {
            get { return fireTank; }
        }
        int step;
        Projectile projectile;
        Random r;
        public Projectile Projectile
        {
            get { return projectile; }
        }
        public Packman Packman
        {
            get { return packman; }
        }
    
        public List<Apple> Apples
        {
            get { return apples; }
        } 
        public List<Tank> Tanks
        {
            get { return tanks; }
        }
     public Model(int sizeField,int amountTanks,int amountApples,int speedGame)
     {
         this.sizeField=sizeField;
         this.amountTanks=amountTanks;
         this.amountApples=amountApples;
         this.speedGame=speedGame;
         r = new Random();
         NewGame();
     }
     void CreateTanks()
     {
         int x, y;
         bool flag;
         
         while (tanks.Count <= amountTanks)
         {
             if (tanks.Count == 0)
                 tanks.Add(new Hunter(sizeField,r.Next(6)*40,r.Next(6)*40));
             x = r.Next(6) * 40;
             y = r.Next(6) * 40;
             flag = true;
             foreach (Tank t in tanks)
             {
                 if (t.X == x && t.Y == y)
                     flag = false;
                 break;
             }
             if (flag)
                 tanks.Add(new Tank(sizeField, x, y));
         }
     }
     void CreateApples(int newApples)
     {
         int x, y;
         bool flag;
         while(apples.Count<=amountApples+newApples)
         {
             x = r.Next(6) * 40-1;
             y = r.Next(6) * 40-2;
             flag = true;
             foreach (Apple a in apples)
             {
                 if(a.X==x&&a.Y==y)
                     break;
             }
             if (flag)
                 apples.Add(new Apple( x, y));
         }

     }
     public void Play()
     {
         while (gameStatus==GameStatus.playing)
         {
             Thread.Sleep(speedGame);
             Packman.Run();
             Projectile.Run();

             ((Hunter)tanks[0]).Run(Packman.X, Packman.Y);
             for (int i = 1; i < tanks.Count;i++ )
                 tanks[i].Run();
             
             foreach (FireTank ft in fireTank)
                 ft.Fire();

             for (int i = 1; i < tanks.Count; i++)
                 if (Math.Abs(tanks[i].X - projectile.X) < 13 && Math.Abs(tanks[i].Y - projectile.Y) < 13&&
                     Math.Abs(tanks[i].X-projectile.X)>7&&Math.Abs(tanks[i].X-projectile.X)>7  )
                 {
                     fireTank.Add(new FireTank(tanks[i].X,tanks[i].Y));
                     tanks.RemoveAt(i);
                     projectile.DefaultSettings();
                 }
                     
             for (int i = 0; i < tanks.Count-1;i++ )
             {
                 for (int j = i + 1; j < tanks.Count;j++ )
                 {
                     if (
                         (Math.Abs(tanks[i].X - tanks[j].X) <= 20 && tanks[i].Y == tanks[j].Y) ||
                         (Math.Abs(tanks[i].Y - tanks[j].Y) <= 20 && tanks[i].X == tanks[j].X) ||
                         (Math.Abs(tanks[i].Y - tanks[j].Y) <= 20 && Math.Abs(tanks[i].X - tanks[j].X) <= 20))
                     {
                         if (i == 0)
                          ((Hunter)tanks[i]).TurnAround();
                         else
                          tanks[i].TurnAround();
                         tanks[j].TurnAround();
                     }
                 }
             }
             for (int i = 0; i < tanks.Count;i++ )
             {
                 if (
                         (Math.Abs(tanks[i].X - Packman.X) <= 19 && tanks[i].Y == Packman.Y) ||
                         (Math.Abs(tanks[i].Y - Packman.Y) <= 19 && tanks[i].X == Packman.X) ||
                         (Math.Abs(tanks[i].Y - Packman.Y) <= 19 && Math.Abs(tanks[i].X - Packman.X) <= 19)
                    )
                     gameStatus = GameStatus.looser;
             }

            for (int i = 0; i < apples.Count; i++)
             {
                 if (Math.Abs(packman.X - apples[i].X) < 13 && Math.Abs(packman.Y - apples[i].Y) < 13)
                 {
                     apples[i] = new Apple(step+=30, 280);
                     
                     CreateApples(collectedApples++);
                 }

             }
            if (collectedApples > 4)
                gameStatus = GameStatus.winner;
             
         }
     }

     public void NewGame()
     {
         projectile = new Projectile();
         packman = new Packman(sizeField);
         tanks = new List<Tank>();
         fireTank = new List<FireTank>();
         apples = new List<Apple>();
         collectedApples = 0;
         gameStatus = GameStatus.stopping;
         wall =new Wall();
         CreateTanks();
         CreateApples(0);
         step = -30;
     }

    }
}
