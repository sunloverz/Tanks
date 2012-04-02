using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Tanks
{
    class TankImg
    {
      Image[] up = { 
             Properties.Resources.TankImg0_1,
             Properties.Resources.TankImg0_1I,
             Properties.Resources.TankImg0_1II,
             Properties.Resources.TankImg0_1III,
             Properties.Resources.TankImg0_1IV };
       
        Image[] down ={
             Properties.Resources.TankImg01,
             Properties.Resources.TankImg01I,
             Properties.Resources.TankImg01II,
             Properties.Resources.TankImg01III,
             Properties.Resources.TankImg01IV };
        Image[] right ={
             Properties.Resources.TankImg10,
             Properties.Resources.TankImg10I,
             Properties.Resources.TankImg10II,
             Properties.Resources.TankImg10III,
             Properties.Resources.TankImg10IV};
        Image[] left ={
             Properties.Resources.TankImg_10,
             Properties.Resources.TankImg_10I,
             Properties.Resources.TankImg_10II,
             Properties.Resources.TankImg_10III,
             Properties.Resources.TankImg_10IV };

        public Image[] Down
        {
            get { return down; }
            
        }
        public Image[] Up
        {
            get { return up; }
           
        }
        public Image[] Right
        {
            get { return right; }
            
        }
        public Image[] Left
        {
            get { return left; }
          
        }
        

       
    }
}
