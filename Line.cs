using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Line : Figures
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private Color color;
        public Line(int x1, int y1, int x2, int y2, Color color)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.color = color;
        }
        public override void Draw(Graphics graph)
        {
            pen.Color = color;
            graph.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
