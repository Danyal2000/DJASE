namespace DJASE
{
    class Circle : Shape
    {

        private int width;


        public void SetWidth(int w)
        {
            width = w;
        }


        public override void Draw(Graphics g, Pen pen, int xPos, int yPos)
        {

            g.DrawEllipse(pen, xPos, yPos, width, width);

        }

        public override void Fill(Graphics g, Pen pen, Brush brush, int xPos, int yPos)
        {
            g.FillEllipse(brush, xPos, yPos, width, width);
        }
    }
}
