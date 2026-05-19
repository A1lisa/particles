using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particles
{
    internal class TeleportPoint : IImpactPoint
    {
        public int Radius = 40;
        public float TargetX;
        public float TargetY;
        public int ExitDirection = 0;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r = (float)Math.Sqrt(gX * gX + gY * gY);

            if (r + particle.Radius < Radius)
            {
                particle.X = TargetX;
                particle.Y = TargetY;

                double radDirection = ExitDirection * Math.PI / 180.0;
                particle.SpeedX += (float)(Math.Cos(radDirection) * 8);
                particle.SpeedY += (float)(Math.Sin (radDirection) * 8);

            }
            

        }

        public override void Render(Graphics g)
        {
            int diameter = Radius * 2;
            g.DrawEllipse(
                new Pen(Color.LimeGreen, 2),
                X - Radius,
                Y - Radius,
                diameter,
                diameter
            );

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            var text = "ВХОД";
            var font = new Font("Verdana", 8);

            g.DrawString(
                text,
                font,
                new SolidBrush(Color.LimeGreen),
                X,
                Y,
                stringFormat
            );

            g.DrawEllipse(
                new Pen(Color.Red, 2),
                TargetX - Radius, 
                TargetY - Radius, 
                diameter,
                diameter
               );
            var text1 = "ВЫХОД";
            var font1 = new Font("Verdana", 8);
            g.DrawString(
                text1,
                font1,
                new SolidBrush(Color.Red),
                TargetX,
                TargetY,
                stringFormat
            );
        }
        
}
}
