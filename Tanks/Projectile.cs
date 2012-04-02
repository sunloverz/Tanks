using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class Projectile
    {
        private ProjectileImg projectileImg = new ProjectileImg();
        private Image img;
        int x, y, direct_x, direct_y;
        public ProjectileImg ProjectileImg
        {
            get { return projectileImg; }
        }
        public Image Img
        {
            get { return img; }
            set { img = value; }
        }
        private void PutImg()
        {
            if (direct_x == 1)
                Img = ProjectileImg.Right;
            if (direct_x == -1)
                Img = ProjectileImg.Left;
            if (direct_y == 1)
                Img = ProjectileImg.Down;
            if (direct_y == -1)
                Img = ProjectileImg.Up;
        }
        public Projectile()
        {
            img = projectileImg.Up;
            DefaultSettings();
        }

        public void DefaultSettings()
        {
           x = y = -10;
           Direct_x = Direct_y = 0;
        }
        public void Run()
        {
            PutImg();
            x += 2*Direct_x;
            y += 2*Direct_y;
        }   

        public int Direct_y
        {
            get { return direct_y; }
            set { if (value==0||value==1||value==-1)
                 direct_y = value; }
        }
        public int Direct_x
        {
            get { return direct_x; }
            set
            {
              if(value==0||value==1||value==-1)
              direct_x =value;
            }
        }
        public int Y
       {
           get { return y; }
           set { y = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value;}
        }
    }
}
