using System.Windows.Forms;

namespace DJASE
{
    public partial class Form1 : Form
    {
        private const int x = 640;
        private const int y = 480;
        private readonly Bitmap OutputBitmap = new(x, y);
        private readonly Canvass MyCanvas;

        public Form1()
        {
            InitializeComponent();
            MyCanvas = new Canvass(Graphics.FromImage(OutputBitmap));

        }
        private void CommandLine_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string command = CommandLine.Text;
                Parser parse = new(MyCanvas);
                parse.Parse(command);
                if (command.Equals("run"))
                {
                    parse.Parse(ProgramWindow.Text);
                }
                ErrLabel.Text = parse.RetFlag();
                Refresh();
            }
        }

            private void RunBtn_Click(object sender, EventArgs e)
            {
                  string command = ProgramWindow.Text;
                  Parser parse = new(MyCanvas);
                  parse.Parse(command);
                  ErrLabel.Text = parse.RetFlag();
                  Refresh();
            }

        private void OutputWindow_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MyCanvas.ClearPanel();
            ErrLabel.Text = "";
            Refresh();
        }

        private void SyntaxBtn_Click(object sender, EventArgs e)
        {
            Syntax syn = new();

            string commands = CommandLine.Text + "\n" + ProgramWindow.Text;
            ErrLabel.Text = syn.SynCheck(commands);


            Refresh();
        }

    }
}