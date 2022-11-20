namespace DJASE
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProgramWindow = new System.Windows.Forms.RichTextBox();
            this.CommandLine = new System.Windows.Forms.TextBox();
            this.OutputWindow = new System.Windows.Forms.PictureBox();
            this.RunBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SyntaxBtn = new System.Windows.Forms.Button();
            this.ErrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgramWindow
            // 
            this.ProgramWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramWindow.Location = new System.Drawing.Point(37, 12);
            this.ProgramWindow.Name = "ProgramWindow";
            this.ProgramWindow.Size = new System.Drawing.Size(481, 477);
            this.ProgramWindow.TabIndex = 4;
            this.ProgramWindow.Text = "";
            // 
            // CommandLine
            // 
            this.CommandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandLine.Location = new System.Drawing.Point(37, 538);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(481, 32);
            this.CommandLine.TabIndex = 5;
            this.CommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandLine_Enter);
            // 
            // OutputWindow
            // 
            this.OutputWindow.BackColor = System.Drawing.Color.White;
            this.OutputWindow.Location = new System.Drawing.Point(690, 10);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(481, 477);
            this.OutputWindow.TabIndex = 6;
            this.OutputWindow.TabStop = false;
            this.OutputWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputWindow_paint);
            // 
            // RunBtn
            // 
            this.RunBtn.BackColor = System.Drawing.Color.Lime;
            this.RunBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RunBtn.Location = new System.Drawing.Point(710, 524);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(103, 50);
            this.RunBtn.TabIndex = 7;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = false;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Crimson;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearBtn.Location = new System.Drawing.Point(867, 524);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(103, 50);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SyntaxBtn
            // 
            this.SyntaxBtn.BackColor = System.Drawing.Color.Red;
            this.SyntaxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SyntaxBtn.Location = new System.Drawing.Point(1027, 524);
            this.SyntaxBtn.Name = "SyntaxBtn";
            this.SyntaxBtn.Size = new System.Drawing.Size(103, 50);
            this.SyntaxBtn.TabIndex = 9;
            this.SyntaxBtn.Text = "Syntax";
            this.SyntaxBtn.UseVisualStyleBackColor = false;
            this.SyntaxBtn.Click += new System.EventHandler(this.SyntaxBtn_Click);
            // 
            // ErrLabel
            // 
            this.ErrLabel.AutoSize = true;
            this.ErrLabel.BackColor = System.Drawing.Color.White;
            this.ErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrLabel.Location = new System.Drawing.Point(699, 24);
            this.ErrLabel.Name = "ErrLabel";
            this.ErrLabel.Size = new System.Drawing.Size(0, 26);
            this.ErrLabel.TabIndex = 10;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1245, 619);
            this.Controls.Add(this.ErrLabel);
            this.Controls.Add(this.SyntaxBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.ProgramWindow);
            this.Name = "form1";
            this.Text = "Simple Programming";
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox ProgramWindow;
        private TextBox CommandLine;
        private PictureBox OutputWindow;
        private Button RunBtn;
        private Button ClearBtn;
        private Button SyntaxBtn;
        private Label ErrLabel;
    }
}