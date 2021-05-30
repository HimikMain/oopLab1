using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Figures
    {
        public Pen pen = new Pen(Color.Black);
        public virtual void Draw(Graphics g)
        {
        }
    }
}
