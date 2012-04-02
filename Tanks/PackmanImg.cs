using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class PackmanImg
    {
        Image[] up = { 
             Properties.Resources.PackmanImg0_1,
             Properties.Resources.PackmanImg0_1I,
             Properties.Resources.PackmanImg0_1II,
             Properties.Resources.PackmanImg0_1III,
             Properties.Resources.PackmanImg0_1IV };
       
        Image[] down ={
             Properties.Resources.PackmanImg01,
             Properties.Resources.PackmanImg01I,
             Properties.Resources.PackmanImg01II,
             Properties.Resources.PackmanImg01III,
             Properties.Resources.PackmanImg01IV };
        Image[] right ={
             Properties.Resources.PackmanImg10,
             Properties.Resources.PackmanImg10I,
             Properties.Resources.PackmanImg10II,
             Properties.Resources.PackmanImg10III,
             Properties.Resources.PackmanImg10IV};
        Image[] left ={
             Properties.Resources.PackmanImg_10,
             Properties.Resources.PackmanImg_10I,
             Properties.Resources.PackmanImg_10II,
             Properties.Resources.PackmanImg_10III,
             Properties.Resources.PackmanImg_10IV };

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
