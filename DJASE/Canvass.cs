using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJASE
{
    public class Canvass
    {
        private readonly Graphics g;
        int xPos=0,yPos=0;
        public Pen pen = new(Color.Black);
        public SolidBrush SolidBrush = new(Color.Black);
        private bool fill = false;


        public Canvass(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
        }

        public void Fill(string fill)
        {
            if (fill.Equals("on"))
            {
                this.fill = true;
            }
            else if (fill.Equals("off"))
            {
                this.fill = false;
            }
        }

        public void DrawTo(int x,int y)
        {
            Line L1 = new();
            L1.SetXY(x,y);
            if (fill == false)
            {
              L1.Draw(g,pen,xPos,yPos);
            }
            else if(fill == true)
            {
                L1.Fill(g,pen,SolidBrush,xPos,yPos);
            }
            
            xPos = x;
            yPos = y;
        }
        public void ChangeColor(String color)
        {
            if (color.Equals("red") == true)
            {
                pen.Color = Color.Red;
                SolidBrush.Color = Color.Red;
            }
            if (color.Equals("green"))
            {
                pen.Color = Color.Green;
                SolidBrush.Color = Color.Green;
            }
            if (color.Equals("blue") == true)
            {
                pen.Color = Color.Blue;
                SolidBrush.Color = Color.Blue;
            }
            if (color.Equals("black") == true)
            {
                pen.Color = Color.Black;
                SolidBrush.Color = Color.Black;
            }
            if (color.Equals("purple") == true)
            {
                pen.Color = Color.Purple;
                SolidBrush.Color = Color.Purple;
            }
            if (color.Equals("yellow") == true)
            {
                pen.Color = Color.Yellow;
                SolidBrush.Color = Color.Yellow;
            }
            if (color.Equals("pink") == true)
            {
                pen.Color = Color.Pink;
                SolidBrush.Color = Color.Pink;
            }
            if (color.Equals("cyan") == true)
            {
                pen.Color = Color.Cyan;
                SolidBrush.Color = Color.Cyan;
            }
            if (color.Equals("magenta") == true)
            {
                pen.Color = Color.Magenta;
                SolidBrush.Color = Color.Magenta;
            }
            if (color.Equals("orange") == true)
            {
                pen.Color = Color.Orange;
                SolidBrush.Color = Color.Orange;
            }
        }
        public void DrawRec(int h, int w)
        {
            Rectangle R1 = new();
            R1.SetHeightWidth(h,w);
            if (fill == false)
            {
                R1.Draw(g,pen,xPos,yPos);
            }
            else if(fill == true)
            {
                R1.Fill(g,pen,SolidBrush,xPos,yPos);
            }
            
        }
        public void DrawTri(int h)
        {
           Triangle T1 = new();
            
            T1.SetHeight(h);
            if(fill == false)
            {
              T1.Draw(g,pen,xPos,yPos);
            }
            else if (fill == true)
            {
              T1.Fill(g,pen,SolidBrush,xPos,yPos);
            }
            
        }

        public void DrawCirc(int w)
        {
            Circle C1 = new();
            C1.SetWidth(w);
            if(fill == false)
            {
                C1.Draw(g,pen,xPos,yPos);
            }
            else if (fill == true)
            {
                C1.Fill(g,pen,SolidBrush, xPos, yPos);
            }
            
        }

        public void MoveTo(int x, int y)
        {
            
            xPos = x;
            yPos = y;
        }

        public void ClearPanel()
        {
            g.Clear(color: Color.White);
            
        }

        public void ResetPanel()
        {
            xPos = 0;
            yPos = 0;
        }
    }
}
