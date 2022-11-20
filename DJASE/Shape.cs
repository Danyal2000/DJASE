using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJASE
{
    abstract class Shape : IShapes
    {

        public abstract void Draw(Graphics g, Pen pen, int xPos, int yPos);
        public abstract void Fill(Graphics g, Pen pen, Brush brush, int xPos, int yPos);
    }
}
