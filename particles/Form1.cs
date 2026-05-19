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
                X = 200,
                Y = picDisplay.Height / 2,
                Radius = tbRadius.Value,
                TargetX = picDisplay.Width - 100,     
                TargetY = picDisplay.Height / 2,

                ExitDirection = tbDirection.Value,
            };
            
            emitter.impactPoints.Add(teleportPoint);
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
            label1.Text = $"Радиус: {tbRadius.Value}";
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            teleportPoint.ExitDirection = tbDirection.Value;
            label3.Text = $"Направление: {tbDirection.Value}°";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
