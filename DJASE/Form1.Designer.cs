namespace DJASE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CommandLine = new System.Windows.Forms.TextBox();
            this.OutputWindow = new System.Windows.Forms.PictureBox();
            this.ProgramWindow = new System.Windows.Forms.RichTextBox();
            this.ErrLabel = new System.Windows.Forms.Label();
            this.SyntaxBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // RunBtn
            // 
            this.RunBtn.BackColor = System.Drawing.Color.Lime;
            this.RunBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.Location = new System.Drawing.Point(710, 524);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(107, 50);
            this.RunBtn.TabIndex = 0;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = false;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Crimson;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(867, 524);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(107, 50);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(37, 538);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(481, 26);
            this.CommandLine.TabIndex = 2;
            this.CommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandLine_Enter);
            // 
            // OutputWindow
            // 
            this.OutputWindow.BackColor = System.Drawing.Color.White;
            this.OutputWindow.Location = new System.Drawing.Point(690, 12);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(481, 477);
            this.OutputWindow.TabIndex = 3;
            this.OutputWindow.TabStop = false;
            this.OutputWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputWindow_paint);
            // 
            // ProgramWindow
            // 
            this.ProgramWindow.Location = new System.Drawing.Point(37, 12);
            this.ProgramWindow.Name = "ProgramWindow";
            this.ProgramWindow.Size = new System.Drawing.Size(481, 477);
            this.ProgramWindow.TabIndex = 4;
            this.ProgramWindow.Text = "";
            // 
            // ErrLabel
            // 
            this.ErrLabel.AutoSize = true;
            this.ErrLabel.BackColor = System.Drawing.Color.White;
            this.ErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.ErrLabel.Location = new System.Drawing.Point(699, 24);
            this.ErrLabel.Name = "ErrLabel";
            this.ErrLabel.Size = new System.Drawing.Size(0, 16);
            this.ErrLabel.TabIndex = 5;
            this.ErrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SyntaxBtn
            // 
            this.SyntaxBtn.BackColor = System.Drawing.Color.Red;
            this.SyntaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SyntaxBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SyntaxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyntaxBtn.Location = new System.Drawing.Point(1027, 524);
            this.SyntaxBtn.Name = "SyntaxBtn";
            this.SyntaxBtn.Size = new System.Drawing.Size(103, 50);
            this.SyntaxBtn.TabIndex = 7;
            this.SyntaxBtn.Text = "Syntax";
            this.SyntaxBtn.UseVisualStyleBackColor = false;
            this.SyntaxBtn.Click += new System.EventHandler(this.SyntaxBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1245, 619);
            this.Controls.Add(this.SyntaxBtn);
            this.Controls.Add(this.ErrLabel);
            this.Controls.Add(this.ProgramWindow);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RunBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CommandLine_Enter(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OutputWindow_paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SyntaxBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox CommandLine;
        private System.Windows.Forms.PictureBox OutputWindow;
        private System.Windows.Forms.RichTextBox ProgramWindow;
        private System.Windows.Forms.Label ErrLabel;
        private System.Windows.Forms.Button SyntaxBtn;
    }
}