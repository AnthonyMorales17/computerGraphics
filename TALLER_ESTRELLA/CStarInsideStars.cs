using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TALLER_ESTRELLA
{
    class CStarInsideStars
    {
        private int maxRadius;
        private int count;
        private Point center;
        private float mRadius;

        public CStarInsideStars(int maxRadius, int count, Point center)
        {
            this.maxRadius = maxRadius * 10;
            this.count = count;
            this.center = center;
        }

        public void Draw(Graphics g, Pen pen)
        {
            for (int i = 0; i < count; i++)
            {
                float factor = (float)(count - i) / count; // escala progresiva
                DrawSingleStar(g, pen, maxRadius * factor);
            }
        }

        private void DrawSingleStar(Graphics g, Pen pen, float radius)
        {
            PointF[] points = new PointF[10];
            double angle = -Math.PI / 2;
            double step = Math.PI / 5;

            for (int i = 0; i < 10; i++)
            {
                double r = (i % 2 == 0) ? radius : radius * 0.5;
                points[i] = new PointF(
                    center.X + (float)(r * Math.Cos(angle)),
                    center.Y + (float)(r * Math.Sin(angle))
                );
                angle += step;
            }

            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(pen, points[i], points[(i + 1) % 10]);
            }
        }

        public void InitializeData(TextBox txtRadius, PictureBox picCanvas)
        {
            mRadius = 0.0f;

            txtRadius.Text = "";
            //Mantiene el cursor titilando en una caja de texto.
            txtRadius.Focus();
            picCanvas.Image = null;
            picCanvas.Refresh();
        }
    }
}