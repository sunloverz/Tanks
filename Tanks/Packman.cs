using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Tanks
{
    class Packman:IRun,ITurn,ITransparent
    {
        PackmanImg packmanImg = new PackmanImg();
        Image[] img;
        Image currentImage;

        int x, y, direct_x, direct_y,nextDirectX,nextDirectY;
     
        int sizeField;
 
       public int NextDirectY
        {
            get { return nextDirectY; }
            set { 
                 if(nextDirectY==1||nextDirectY==0||nextDirectY==-1)
                  nextDirectX = value; 
                }
            
        }
        public int NextDirectX
        {
            get { return nextDirectX; }
            set {
                 if(nextDirectX==1||nextDirectX==-1||nextDirectX==0)
                  nextDirectY = value;
                }
            
        }
        public Image CurrentImage
        {
            get { return currentImage; }
        }
        
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Direct_y
        {
            get { return direct_y; }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    direct_y = value;
            }
        }
        public int Direct_x
        {
            get { return direct_x; }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    direct_x = value;
            }
        }
       public Packman(int sizeField)
        {
            this.sizeField = sizeField;
            this.x = 120;
            this.y = 240;
            this.direct_x = 0;
            this.direct_y = -1; 
            this.nextDirectX = 0;
            this.nextDirectY = -1;
            PutImg();
            PutCurrentImage();       
        }

        public void Run()
        {
           Transparent();
            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
                Turn(); 
            PutCurrentImage();
        }
        int k;
        private void  PutCurrentImage()
        {
            currentImage = img[k++];
            if (k == 5) k = 0;
        }
        public void Turn()
        {
            direct_x = NextDirectX;
            direct_y = NextDirectY;
            PutImg();
        }
        public void Transparent()
        {
            if (x == -1)
                x = sizeField - 21;
            if (x == sizeField - 19)
                x = 1;
            if (y == -1)
                y = sizeField - 21;
            if (y == sizeField - 19)
                y = 1;
        }
        void PutImg()
        {
            if (direct_x == 1)
                img = packmanImg.Right;
            if (direct_x == -1)
                img = packmanImg.Left;
            if (direct_y == 1)
                img = packmanImg.Down;
            if (direct_y == -1)
                img = packmanImg.Up;
        }
    }
}
