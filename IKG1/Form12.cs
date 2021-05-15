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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        PictureBox pb = new PictureBox();

        private void Form12_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pb);
        }

        private void Form12_Paint(object sender, PaintEventArgs e)
        {
            pb.Width = 500;
            pb.Height = 300;
            Graphics g = pb.CreateGraphics();
            GraphicsPath MyPath = new GraphicsPath();
            MyPath.AddRectangle(new Rectangle(0, 0, 200, 100));
            PathGradientBrush myBrush = new PathGradientBrush(MyPath);
            Color[] redColor = { Color.Red };
            myBrush.SurroundColors = redColor;
            myBrush.CenterColor = Color.Aqua;
            g.FillPath(myBrush, MyPath);
            myBrush.FocusScales = new PointF(0.2F, 0.5F);
            g.TranslateTransform(0.0F, 150.0F);
            g.FillPath(myBrush, MyPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
