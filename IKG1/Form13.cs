using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace IKG1
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        PictureBox pb = new PictureBox();

        private void Form13_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pb);
        }

        private void Form13_Paint(object sender, PaintEventArgs e)
        {
            pb.Width = 500;
            pb.Height = 300;
            Graphics g = pb.CreateGraphics();
            Point[] myPoints =
            {
                new Point(0, 0),
                new Point(200, 0),
                new Point(200, 200),
                new Point(0, 200)
            };
            PathGradientBrush myBrush = new PathGradientBrush(
                myPoints);
            Color[] colors =
            {
                Color.FromArgb(255, 0, 128, 0),
                Color.FromArgb(255, 128, 0, 255),
                Color.FromArgb(255, 0, 128, 128)
            };
            float[] relativePositions = { 0.0F, 0.4F, 1.0F };
            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Colors = colors;
            colorBlend.Positions = relativePositions;
            myBrush.InterpolationColors = colorBlend;
            g.FillRectangle(myBrush, 0, 0, 200, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
