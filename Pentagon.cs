using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Pentagon : Figures
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private int x4;
        private int y4;
        private int x5;
        private int y5;
        private Color color;
        public Pentagon(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int x5, int y5, Color color)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
            this.x5 = x5;
            this.y5 = y5;
            this.color = color;
        }
        public override void Draw(Graphics graph)
        {
            pen.Color = color;
            Point[] points = new Point[5];
            points[0].X = x1; points[0].Y = y1;
            points[1].X = x2; points[1].Y = y2;
            points[2].X = x3; points[2].Y = y3;
            points[3].X = x4; points[3].Y = y4;
            points[4].X = x5; points[4].Y = y5;
            graph.DrawPolygon(pen, points);
        }
    }
}
