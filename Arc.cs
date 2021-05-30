using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Arc : Figures
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private int startAngle;
        private int sweepAngle;
        private Color color;
        public Arc(int x, int y, int width, int height, int startAngle, int sweepAngle, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
            this.color = color;
        }
        public override void Draw(Graphics graph)
        {
            pen.Color = color;
            graph.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
        }
    }
}
