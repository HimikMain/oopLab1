using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);

            Line line = new Line(130, 70, 300, 400, Color.Black);
            Rectangle rectangle = new Rectangle(10, 10, 200, 400, Color.Red);
            Ellipse ellipse = new Ellipse(400, 240, 150, 120, Color.Green);
            Arc arc = new Arc(320, 180, 120, 120, 0, 180, Color.Blue);
            Triangle triangle = new Triangle(50, 50, 225, 50, 225, 225, Color.DarkGreen);
            Pentagon pentagon = new Pentagon(700, 300, 640, 270, 680, 220, 750, 270, 760, 320, Color.MediumVioletRed);

            List<Figures> list = new List<Figures>();

            list.Add(line);
            list.Add(rectangle);
            list.Add(ellipse);
            list.Add(arc);
            list.Add(triangle);
            list.Add(pentagon);

            foreach (Figures drawFigure in list)
            {
                drawFigure.Draw(graph);
            }

            pictureBox1.Image = bmp;
        }
    }
}
