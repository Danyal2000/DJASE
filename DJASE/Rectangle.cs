using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJASE
{
    class Rectangle : Shape
    {
        private int height;
        private int width;

       

         public void SetHeightWidth(int h,int w) 
        {
            height = h;
            width = w;
        }

      
        public override void Draw(Graphics g, Pen pen, int xPos, int yPos)
        {
            g.DrawRectangle(pen, xPos, yPos, width, height);
        }

        public override void Fill(Graphics g,Pen pen, Brush brush, int xPos, int yPos)
        {
           g.FillRectangle(brush, xPos, yPos, width, height);
        }
    }
}
