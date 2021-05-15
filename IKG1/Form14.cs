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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        PictureBox pb = new PictureBox();

        private void Form14_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pb);
        }

        private void Form14_Paint(object sender, PaintEventArgs e)
        {
            pb.Width = 500;
            pb.Height = 500;
            Graphics g = pb.CreateGraphics();
            GraphicsPath path = new GraphicsPath();
            PointF[] Mypoints =
            {
                new Point(0, 200),
                new Point(200, 0),
                new Point(400, 200),
                new Point(200, 400)
            };
            path.AddPolygon(Mypoints);
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterPoint = new PointF(120, 40);
            pthGrBrush.CenterColor = Color.DarkRed;
            Color[] colors = { Color.CornflowerBlue };
            pthGrBrush.SurroundColors = colors;
            g.FillPolygon(pthGrBrush, Mypoints);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form15()).ShowDialog();
            this.Close();
        }
    }
}
