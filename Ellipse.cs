using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Ellipse : Figures
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private Color color;
        public Ellipse(int x, int y, int width, int height, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
        }
        public override void Draw(Graphics graph)
        {
            pen.Color = color;
            graph.DrawEllipse(pen, x, y, width, height);
        }
    }
}
