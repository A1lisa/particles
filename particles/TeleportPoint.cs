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
        public int Radius = 50;
        public int Power = 100;

        public float TargetX;
        public float TargetY;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r>250)
            {
                return;
            }

            if (particle.Cooldown <= 0 && r > 10)
            {
                float r2 = (float)Math.Max(200, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
           
            if (r < Radius * 1.5f)
            {
                particle.SpeedX *= 0.95f;
                particle.SpeedY *= 0.95f;
            }
            float maxSpeed = 12f;
            particle.SpeedX = Math.Max(-maxSpeed, Math.Min(maxSpeed, particle.SpeedX));
            particle.SpeedY = Math.Max(-maxSpeed, Math.Min(maxSpeed, particle.SpeedY));

            if (r + particle.Radius < Radius)
            {
                particle.X = TargetX;
                particle.Y = TargetY;
                particle.Cooldown = 30;
               
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
        }
        
}
}
