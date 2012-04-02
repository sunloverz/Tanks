using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Tanks
{
     partial class View : UserControl
    {
        Model model;
        public View(Model model)
        {
            InitializeComponent();
            this.model = model;
        }
         private void DrawWall(PaintEventArgs e)
         {
           for (int y = 20; y < 260; y += 40)
              for (int x = 20; x < 260; x += 40 )               
               e.Graphics.DrawImage(model.wall.Img, new Point(x,y));
         }
         private void DrawTank(PaintEventArgs e)
         {
             for (int i = 0; i < model.Tanks.Count; i++)
                 e.Graphics.DrawImage(model.Tanks[i].CurrentImg,new Point(model.Tanks[i].X,model.Tanks[i].Y));
         }
         private void DrawApple(PaintEventArgs e)
         {
             for (int i = 0; i < model.Apples.Count; i++)
                 e.Graphics.DrawImage(model.Apples[i].Img, new Point(model.Apples[i].X, model.Apples[i].Y));
         }
         private void DrawPackman(PaintEventArgs e)
         {
             e.Graphics.DrawImage(model.Packman.CurrentImage,new Point(model.Packman.X,model.Packman.Y));
         }
         private void DrawProjectile(PaintEventArgs e)
         {
             e.Graphics.DrawImage(model.Projectile.Img,new Point(model.Projectile.X,model.Projectile.Y));
         }
         private void DrawFireTank(PaintEventArgs e)
         {
             foreach (FireTank ft in model.FireTank)
                 e.Graphics.DrawImage(ft.CurrentImg,new Point(ft.X,ft.Y));
         }
        private void Draw(PaintEventArgs e)
        {
            DrawWall(e);
            DrawFireTank(e);
            DrawApple(e);
            DrawTank(e);
            DrawPackman(e);
            DrawProjectile(e);
            if (model.gameStatus != GameStatus.playing)
                return;
           Thread.Sleep(model.speedGame);
           Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }
        
    }
}
