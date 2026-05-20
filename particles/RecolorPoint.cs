using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace particles
{
    public class RecolorPoint : IImpactPoint
    {
        public int Radius = 25;           
        public Color TargetColor;         

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r = (float)Math.Sqrt(gX * gX + gY * gY);

            if (r + particle.Radius < Radius)
            {
                if (particle is ParticleColorful colorful)
                {
                    colorful.FromColor = TargetColor;
                    colorful.ToColor = Color.FromArgb(0, TargetColor);
                }
            }
        }

        public override void Render(Graphics g)
        {
            int diameter = Radius * 2;

            using (var pen = new Pen(TargetColor, 2))
            using (var brush = new SolidBrush(Color.FromArgb(80, TargetColor)))
            {
                g.DrawEllipse(pen, X - Radius, Y - Radius, diameter, diameter);
                g.FillEllipse(brush, X - Radius, Y - Radius, diameter, diameter);
            }

        }
    }
}
