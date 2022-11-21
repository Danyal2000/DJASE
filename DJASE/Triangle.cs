using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJASE
{
  class Triangle:Shape
    {
        private int height;



        public void SetHeight(int h)
        {
            height = h;
           
          
        }


        public override void Draw(Graphics g, Pen pen, int xPos, int yPos)
        {

            Point[] point = new Point[3];
            point[0].X = xPos;
            point[0].Y = xPos - height;
            point[1].X = (int)xPos - (height / 2);
            point[1].Y = yPos;
            point[2].X = (int)xPos + (height / 2);
            point[2].Y = yPos;

            g.DrawPolygon(pen,point);

        }

        public override void Fill(Graphics g,Pen pen, Brush brush, int xPos, int yPos)
        {
            Point[] point = new Point[3];
            point[0].X = xPos;
            point[0].Y = xPos - height;
            point[1].X = (int)xPos - (height / 2);
            point[1].Y = yPos;
            point[2].X = (int)xPos + (height / 2);
            point[2].Y = yPos;

            g.FillPolygon(brush,point);
        }
    }
}
