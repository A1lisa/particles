using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particles
{
    public class ExitPoint : IImpactPoint
    {
         public int Speed = 10;           
        public int Direction = 0;        
        public int Spreading = 30; 

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

         if (r + particle.Radius < 20)
            {
                double radDirection = Direction / 180.0 * Math.PI;
                double randomSpread = (Particle.rand.NextDouble() - 0.5) * Spreading / 180.0 * Math.PI;
                double finalDirection = radDirection + randomSpread;

                particle.SpeedX = (float)(Math.Cos(finalDirection) * Speed);
                particle.SpeedY = (float)(Math.Sin(finalDirection) * Speed);
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                       new Pen(Color.Cyan, 2),
                       X - 20,
                       Y - 20,
                       60,
                       60
                   );
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            var text = "ВЫХОД";
            var font = new Font("Verdana", 8);
            g.DrawString(
                text,
                font,
                new SolidBrush(Color.Cyan),
                X,
                Y,
                stringFormat
            );
        }
    }
}
