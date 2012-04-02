using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Tanks
{
    class HunterImg
    {
        Image[] up = { 
             Properties.Resources.HunterImg0_1,
             Properties.Resources.HunterImg0_1I,
             Properties.Resources.HunterImg0_1II,
             Properties.Resources.HunterImg0_1III,
             Properties.Resources.HunterImg0_1IV };

        Image[] down ={
             Properties.Resources.HunterImg01,
             Properties.Resources.HunterImg01I,
             Properties.Resources.HunterImg01II,
             Properties.Resources.HunterImg01III,
             Properties.Resources.HunterImg01IV };
        Image[] right ={
             Properties.Resources.HunterImg10,
             Properties.Resources.HunterImg10I,
             Properties.Resources.HunterImg10II,
             Properties.Resources.HunterImg10III,
             Properties.Resources.HunterImg10IV};
        Image[] left ={
             Properties.Resources.HunterImg_10,
             Properties.Resources.HunterImg_10I,
             Properties.Resources.HunterImg_10II,
             Properties.Resources.HunterImg_10III,
             Properties.Resources.HunterImg_10IV };

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
