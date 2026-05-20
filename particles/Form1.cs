using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace particles
{
    public partial class Form1 : Form
    {
       // List<Emitter> emitters = new List<Emitter>();
        Emitter emitter; 

        TeleportPoint teleportPoint;

        RecolorPoint recolorRed;
        RecolorPoint recolorGreen;
        RecolorPoint recolorBlue;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image=new Bitmap (picDisplay.Width,picDisplay.Height);

            this.emitter = new Emitter 
            {
                Direction = 0,
                Spreading = 30,
                SpeedMin = 4,
                SpeedMax = 6,
                ColorFrom = Color.White,
                ColorTo = Color.FromArgb(0, Color.Blue),
                ParticlesPerTick = 10,
                X = 0,
                Y = picDisplay.Height / 2,
                LifeMin = 300,          
                LifeMax = 400,
            };


            teleportPoint = new TeleportPoint
            {
                X = 100,
                Y = picDisplay.Height / 2,
                Radius = tbRadius.Value,
                TargetX = 250,     
                TargetY = picDisplay.Height / 2,

                ExitDirection = tbDirection.Value,
            };

            recolorRed = new RecolorPoint
            {
                X =tbRedX.Value,
                Y = picDisplay.Height / 2 -100,
                Radius = tbRadius.Value,
                TargetColor = Color.Red
            };
            recolorGreen = new RecolorPoint
            {
                X = tbGreenX.Value,
                Y = picDisplay.Height / 2,
                Radius = tbRadius.Value,
                TargetColor = Color.LimeGreen
            };

            recolorBlue = new RecolorPoint
            {
                X = tbBlueX.Value,
                Y = picDisplay.Height / 2+100,
                Radius = tbRadius.Value,
                TargetColor = Color.DodgerBlue
            };

            emitter.impactPoints.Add(teleportPoint);

            emitter.impactPoints.Add(recolorRed);
            emitter.impactPoints.Add(recolorGreen);
            emitter.impactPoints.Add(recolorBlue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }
            picDisplay.Invalidate();

        }
        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                teleportPoint.X = e.X;
                teleportPoint.Y = e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                teleportPoint.TargetX = e.X;
                teleportPoint.TargetY = e.Y;
            }
        }

        private void tbRadius_Scroll(object sender, EventArgs e)
        {
            teleportPoint.Radius = tbRadius.Value;
            recolorRed.Radius = tbRadius.Value;
            recolorGreen.Radius = tbRadius.Value;
            recolorBlue.Radius = tbRadius.Value;

            label1.Text = $"Радиус: {tbRadius.Value}";
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            teleportPoint.ExitDirection = tbDirection.Value;
            label3.Text = $"Направление выхода: {tbDirection.Value}°";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbRedX_Scroll(object sender, EventArgs e)
        {
            recolorRed.X = tbRedX.Value;
            lblRedX.Text = $"Положение красного круга по Х: {tbRedX.Value}";
        }

        private void tbGreenX_Scroll(object sender, EventArgs e)
        {
            recolorGreen.X = tbGreenX.Value;
            lblGreenX.Text = $"Положение зеленого круга по Х: {tbGreenX.Value}";
        }

        private void tbBlueX_Scroll(object sender, EventArgs e)
        {
            recolorBlue.X = tbBlueX.Value;
            lblBlueX.Text = $"Положение синего круга по Х: {tbBlueX.Value}";
        }
    }
}
