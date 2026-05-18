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

        TeleportPoint teleportIn;   
        ExitPoint teleportOut;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image=new Bitmap (picDisplay.Width,picDisplay.Height);

            this.emitter = new Emitter 
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 4,
                SpeedMax = 6,
                ColorFrom = Color.White,
                ColorTo = Color.FromArgb(0, Color.Blue),
                ParticlesPerTick = 8,
                X = 100,
                Y =100,
                GravitationX = 0,
                GravitationY = 0,
                LifeMin = 300,          
                LifeMax = 400,
            };


            teleportIn = new TeleportPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
                Radius = tbRadius.Value,
                Power = 300,
                TargetX = picDisplay.Width - 100,     
                TargetY = picDisplay.Height / 2,
            };
            teleportOut = new ExitPoint
            {
                X = picDisplay.Width -100,
                Y = picDisplay.Height / 2,
                Speed = 12,
                Direction = tbDirection.Value,           
                Spreading = 45
            }; 
            emitter.impactPoints.Add(teleportIn);
            emitter.impactPoints.Add(teleportOut);
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
                teleportIn.X = e.X;
                teleportIn.Y = e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                teleportOut.X = e.X;
                teleportOut.Y = e.Y;

                teleportIn.TargetX = teleportOut.X;
                teleportIn.TargetY = teleportOut.Y;
            }
        }

        private void tbRadius_Scroll(object sender, EventArgs e)
        {
            teleportIn.Radius = tbRadius.Value;
            label1.Text = $"Радиус: {tbRadius.Value}";
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            teleportOut.Direction = tbDirection.Value;
            label3.Text = $"Направление: {tbDirection.Value}°";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
