
namespace PaintRNG
{
    partial class formPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPaint));
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.btnSeed = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.PictureBox();
            this.btnEraser = new System.Windows.Forms.PictureBox();
            this.btnBrushSize = new System.Windows.Forms.NumericUpDown();
            this.btnColorBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnPencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.AllowDrop = true;
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Location = new System.Drawing.Point(85, 80);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(512, 512);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // btnSeed
            // 
            this.btnSeed.BackColor = System.Drawing.Color.HotPink;
            this.btnSeed.FlatAppearance.BorderSize = 0;
            this.btnSeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeed.Location = new System.Drawing.Point(283, 617);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(102, 23);
            this.btnSeed.TabIndex = 1;
            this.btnSeed.Text = "Generate Seed";
            this.btnSeed.UseVisualStyleBackColor = false;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.HotPink;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(85, 615);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPencil.BackgroundImage")));
            this.btnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPencil.Location = new System.Drawing.Point(12, 80);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(49, 48);
            this.btnPencil.TabIndex = 3;
            this.btnPencil.TabStop = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEraser.BackgroundImage")));
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEraser.Location = new System.Drawing.Point(12, 214);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(50, 48);
            this.btnEraser.TabIndex = 4;
            this.btnEraser.TabStop = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnBrushSize
            // 
            this.btnBrushSize.Location = new System.Drawing.Point(12, 134);
            this.btnBrushSize.Name = "btnBrushSize";
            this.btnBrushSize.Size = new System.Drawing.Size(49, 20);
            this.btnBrushSize.TabIndex = 5;
            // 
            // btnColorBox
            // 
            this.btnColorBox.BackColor = System.Drawing.Color.Black;
            this.btnColorBox.Location = new System.Drawing.Point(12, 160);
            this.btnColorBox.Name = "btnColorBox";
            this.btnColorBox.Size = new System.Drawing.Size(49, 48);
            this.btnColorBox.TabIndex = 6;
            this.btnColorBox.TabStop = false;
            this.btnColorBox.Click += new System.EventHandler(this.btnColorBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(61, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.HotPink;
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.btnExitApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 48);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Paint Random Number Generator";
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.MistyRose;
            this.btnExitApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApp.FlatAppearance.BorderSize = 0;
            this.btnExitApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.ForeColor = System.Drawing.Color.MistyRose;
            this.btnExitApp.Image = ((System.Drawing.Image)(resources.GetObject("btnExitApp.Image")));
            this.btnExitApp.Location = new System.Drawing.Point(600, 3);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(41, 31);
            this.btnExitApp.TabIndex = 16;
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // formPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(653, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnColorBox);
            this.Controls.Add(this.btnBrushSize);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnPencil);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSeed);
            this.Controls.Add(this.pnlCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RNGPainter";
            ((System.ComponentModel.ISupportInitialize)(this.btnPencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrushSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox btnPencil;
        private System.Windows.Forms.PictureBox btnEraser;
        private System.Windows.Forms.NumericUpDown btnBrushSize;
        private System.Windows.Forms.PictureBox btnColorBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Label label1;
    }
}

