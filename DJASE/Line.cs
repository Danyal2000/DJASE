using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJASE
{
     class Line : Shape
    {
        private int x;
        private int y;



        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public override void Draw(Graphics g, Pen pen, int xPos, int yPos)
        {
            PointF point1 = new PointF(x, y);
            PointF point2 = new PointF(xPos, yPos);
            g.DrawLine(pen, point1, point2);
        }

        public override void Fill(Graphics g,Pen pen, Brush brush, int xPos, int yPos)
        {
            
            PointF point1 = new PointF(x, y);
            PointF point2 = new PointF(xPos, yPos);
            g.DrawLine(pen, point1, point2);
        }
    }
}
