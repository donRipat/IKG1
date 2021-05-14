using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKG1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        PictureBox mypb = new PictureBox();

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            mypb.Width = 300;
            mypb.Height = 300;
            this.Controls.Add(mypb);
            Graphics g = mypb.CreateGraphics();
            Brush myBrush = new SolidBrush(Color.Blue);
            PointF a = new PointF(0, 0),
                b = new PointF(150, 150);
            float start = 0;
            float end = 120;
            g.FillPie(myBrush, a.X, a.Y, b.X, b.Y, start, end);
        }
    }
}
