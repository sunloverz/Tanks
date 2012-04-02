using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Tanks
{
    class FireTank
    {
        FireTankImg ftImg = new FireTankImg();
        Image currentImg;
        Image[] img;
        int x, y;
        public FireTank(int x,int y)
        {
            this.x = x;
            this.y = y;
            img = ftImg.Img;
            PutCurrentImage();
        }
        public void Fire()
        {
            PutCurrentImage();
        }

        int k;
       private void PutCurrentImage()
        {
            CurrentImg = Img[k++];
            if (k == 6) k = 0;
        }
        public int Y
        {
            get { return y; }
        }
        public int X
        {
            get { return x; }
        }
        public Image[] Img
        {
            get { return img; }
        }
        public Image CurrentImg
        {
            get { return currentImg; }
            set { currentImg = value; }
        }
      

    }
}
