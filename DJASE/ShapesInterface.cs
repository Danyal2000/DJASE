using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJASE
{
    interface IShapes
    {


        void Draw(Graphics g, Pen pen, int xPos, int yPos);
        void Fill(Graphics g, Pen pen, Brush brush, int xPos, int yPos);
    }
}
