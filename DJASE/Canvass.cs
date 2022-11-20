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
        int xPos = 0, yPos = 0;
        public Pen pen = new Pen(Color.Black);
        public SolidBrush SolidBrush = new SolidBrush(Color.Black);
        private bool fill = false;




        public Canvass(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
        }
    }
}
