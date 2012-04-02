using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    class ProjectileImg
    {
        Image up =  Properties.Resources.Projectile0_1;
        Image down =Properties.Resources.Projectile01;
        Image right =Properties.Resources.Projectile10;
        Image left =Properties.Resources.Projectile_10;
        public Image Down
        {
            get { return down; }
        }
        public Image Up
        {
            get { return up; }
        }
        public Image Right
        {
            get { return right; }
        }
        public Image Left
        {
            get { return left; }
        }
        
    }
}
