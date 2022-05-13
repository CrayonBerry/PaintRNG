// Convert pixel data into useable seed data, random number generator
// Single form drawing space for user input of pixel data.
// Take pixel data and convert into a useable seed form
// through use of algorithmic hashing


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;



namespace PaintRNG
{
    public partial class formPaint : Form
    {

        string outputPath = Path.GetDirectoryName(Application.ExecutablePath);

        public Point current = new Point();
        public Point old = new Point();

        public Graphics g;
        public Graphics graph;

        public Pen pen = new Pen(Color.Black);

        Bitmap surface;

        public formPaint()
        {
            InitializeComponent();

            g = pnlCanvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            surface = new Bitmap(pnlCanvas.Width, pnlCanvas.Height);

            graph = Graphics.FromImage(surface);
            pnlCanvas.BackgroundImageLayout = ImageLayout.None;

            pen.Width = (float)btnBrushSize.Value;
 
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //mouse click event location data at time of button press
            old = e.Location;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                //mouse move event location that updates based off old mouse click event location data (mouse drag)
                current = e.Location;
                g.DrawLine(pen, old, current);
                graph.DrawLine(pen, old, current);

                old = current;
            }
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            
            pen.Color = Color.White;
            pen.Width = 10;
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            pen.Color = btnColorBox.BackColor;
            pen.Width = (float)btnBrushSize.Value;
        }

        private void btnColorBox_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if(cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
                btnColorBox.BackColor = cd.Color;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (graph = Graphics.FromImage(surface))
            {
                graph.Clear(Color.White);
                pnlCanvas.Invalidate();
            }

            g = pnlCanvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            surface = new Bitmap(pnlCanvas.Width, pnlCanvas.Height);

            graph = Graphics.FromImage(surface);
            pnlCanvas.BackgroundImageLayout = ImageLayout.None;

        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            DialogResult seedMessage = MessageBox.Show("Generate new seed from pixel data and export to .txt?", "Confirmation");

            if (seedMessage == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(Path.Combine(outputPath+ "RNGoutput.txt"));

                double finalTotal = 0;
                //every pixel should now output a unique value based on its position and color data

                //converts pixel color(ARGB) data into double data type, then generates a unique value per pixel based on its position and color data
                for (int i = 0; i < surface.Width; i++)
                {
                    for (int j = 0; j < surface.Height; j++)
                    {
                        Color pixel = surface.GetPixel(i, j);

                        int alpha = pixel.A;
                        int red = pixel.R;
                        int green = pixel.G;
                        int blue = pixel.B;
                        float brightness = pixel.GetBrightness();
                        float hue = pixel.GetHue();
                        float saturation = pixel.GetSaturation();

                        //in order for x and y coordinates to generate unique values, first x has to be above the integer value 1, solution was to set it to its current value plus 1.1
                        //to generate unique values based on y coordinate I had to take a similar approach, first I found that having the integer whole value of y be based on its position value in the grid (i.e. 1-64) it generated numbers far too large for the output and would overflow the double datatype
                        //to fix that problem I thought to multiply the y value by 0.1 to avoid any overflow, then similar to the x coordinate, I add 0.1 to whatever value it spits out, so each iteration of the loop outputs a different value of y in order to generate unique numbers
                        double x = (i * 0.1) + 0.2;
                        double y = (j * 0.01) + 0.1;

                        double xCoord = (x + alpha + red + green + blue);
                        double yCoord = (brightness + hue + saturation + y);

                        double function = xCoord / yCoord;

                        double power = Math.Pow(function, y);
                        
                        // final total is the sum of all pixel values
                        finalTotal += power;

                        string readOut = power.ToString() + "\n";

                        //the readout of each pixel value
                        sw.Write(readOut);
                    }
                }
                // number looks weird, because I initially started without size being a thing you can change, taking that into consideration though, I decided to divide that number by the multiple of the height and width, thus giving me more freedom to play with size and get an equivalent modulo number.
                double modulo = finalTotal % (494975009.082627); // rather than using grid x and y, I went back to my earlier method of finding the samllest possible number the grid can generate (perform hash with white background) and using that as the modulo number


                sw.Write(finalTotal + "\n");
                sw.Write(modulo);
                Console.WriteLine(modulo + "\n");
                sw.Close();
                
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Images|*.png;";
            save.FilterIndex = 1;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {

                surface.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Images|*.png;";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == DialogResult.OK)
            {

                surface = new Bitmap(open.FileName);
            }

            pnlCanvas.Width = surface.Width;
            pnlCanvas.Height = surface.Height;

            pnlCanvas.BackgroundImage = surface;
            graph = Graphics.FromImage(surface);
            
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
