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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        PictureBox mypb = new PictureBox();

        private void Form11_Load(object sender, EventArgs e)
        {
            this.Controls.Add(mypb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            mypb.Width = 500;
            mypb.Height = 300;
            Graphics g = mypb.CreateGraphics();
            PointF[] myPoints =
            {
                new PointF(30, 0),
                new PointF(60, 0),
                new PointF(90, 30),
                new PointF(90, 60),
                new PointF(60, 90),
                new PointF(30, 90),
                new PointF(0, 60),
                new PointF(0, 30)
            };
            PathGradientBrush myBrush = new PathGradientBrush(myPoints);
            Color[] colors =
            {
                Color.FromArgb(255, 255, 0, 0),
                Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 0, 0, 255),
                Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 255, 0, 0),
                Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 0, 0, 255),
                Color.FromArgb(255, 255, 0, 0)
            };
            myBrush.SurroundColors = colors;
            myBrush.CenterColor = Color.White;
            g.FillRectangle(myBrush, new Rectangle(0, 0, 200, 200));
        }
    }
}
