namespace DJASE
{
    public partial class form1 : Form
    {
        private const int x = 640;
        private const int y = 480;
        private Bitmap OutputBitmap = new Bitmap(x, y);
        private Canvass MyCanvas;

        public form1()
        {
            InitializeComponent();
            MyCanvas = new Canvass(Graphics.FromImage(OutputBitmap));

        }
        private void CommandLine_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string command = CommandLine.Text;
                Parser parse = new Parser(MyCanvas); // handling the parser class the canvas needed to draw on the screen
                parse.Parse(command);
                if (command.Equals("run"))
                {
                    parse.Parse(ProgramWindow.Text);
                }
                //ErrLabel.Text = parse.RetFlag();
                Refresh();
            }
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