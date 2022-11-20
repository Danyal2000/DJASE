namespace DJASE
{
    public partial class Form1 : Form
    {
        private const int x = 640;
        private const int y = 480;
        private Bitmap OutputBitmap = new Bitmap(x, y);
        private Canvass MyCanvas;

        public Form1()
        {
            InitializeComponent();
            MyCanvas = new Canvass(Graphics.FromImage(OutputBitmap));

        }
        private void CommandLine_Enter(object sender, KeyEventArgs e)
            {

            }

            private void RunBtn_Click(object sender, EventArgs e)
            {

            }

        private void OutputWindow_paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void SyntaxBtn_Click(object sender, EventArgs e)
        {

        }
    }
}