using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Tanks
{
    public partial class Controller_MainForm : Form
    {
        View view;
        Model model;
        Thread modelPlay;
        public Controller_MainForm(int sizeField,int amountTanks,int amountApples,int speedGame)
        {
            InitializeComponent();
            model = new Model(sizeField,amountTanks,amountApples,speedGame);
            view = new View(model);
            this.Controls.Add(view);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (model.gameStatus ==GameStatus.playing)
            {
                pictureBox1.Image = Properties.Resources.PlayButton;
                modelPlay.Abort();
                model.gameStatus=GameStatus.stopping;
            }
            else
            {
                pictureBox1.Focus();
                model.gameStatus=GameStatus.playing;
                modelPlay=new Thread(model.Play);
                modelPlay.Start();
                pictureBox1.Image = Properties.Resources.PauseButton;
                view.Invalidate();
            }
             
        }

        private void Controller_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modelPlay != null)
                modelPlay.Abort();
        }

     

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
             switch (e.KeyData.ToString())

            {
                case "W": { model.Packman.NextDirectX = -1; model.Packman.NextDirectY = 0;} break; 
                case "S": { model.Packman.NextDirectX = 1; model.Packman.NextDirectY = 0;} break; 
                case "A": { model.Packman.NextDirectY = -1; model.Packman.NextDirectX = 0;}break;  
                case "D": { model.Packman.NextDirectY = 1; model.Packman.NextDirectX = 0; } break;
                case "F":
                    {
                        model.Projectile.Direct_x = model.Packman.Direct_x;
                        model.Projectile.Direct_y = model.Packman.Direct_y;
                        if (model.Packman.Direct_y == -1)
                        {
                            model.Projectile.X = model.Packman.X + 10;
                            model.Projectile.Y = model.Packman.Y;
                        }
                           
                        if (model.Packman.Direct_y == 1)
                        {
                            model.Projectile.X = model.Packman.X + 10;
                            model.Projectile.Y = model.Packman.Y + 20;
                        }
                        if (model.Packman.Direct_x == -1)
                        {
                            model.Projectile.X = model.Packman.X;
                            model.Projectile.Y=model.Packman.Y+10;
                        }
                            
                        if (model.Packman.Direct_x == 1)
                        {
                            model.Projectile.X=model.Packman.X+20;
                            model.Projectile.Y = model.Packman.Y + 10;
                        }
                    }  break;      
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.NewGame();
            pictureBox1.Image = Properties.Resources.PlayButton;
            view.Invalidate();
            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Omurbekov Aydar\ne-mail: sunloverz.kg@gmail.com\n A,S,D,W,F to control","Tanks");
        }
    }
}
