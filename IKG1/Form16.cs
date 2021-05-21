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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        PictureBox pb = new PictureBox();
        Graphics g;
        Point s1 = new Point(10, 100);
        Point e1 = new Point(100, 10);
        Point e2 = new Point(150, 150);
        Point s2 = new Point(200, 100);
        Pen myPen = new Pen(Color.Black, 3);

        private void Form16_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pb);
            pb.Width = 210;
            pb.Height = 210;
            g = pb.CreateGraphics();
            Form16_Paint(sender, null);
        }

        private void Form16_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            g.DrawBezier(myPen, s1, e1, e2, s2);
        }

        private void hScrollBar1_Scroll(object sender, 
            ScrollEventArgs e)
        {
            g.ResetTransform();
            Matrix myMatrix = new Matrix();
            myMatrix.RotateAt(hScrollBar1.Value, new PointF(
                pb.Height / 2, pb.Width / 2), MatrixOrder.Append);
            g.Transform = myMatrix;
            DrawShapeLine(g);
        }

        private void DrawShapeLine(Graphics g)
        {
            g.Clear(Color.White);
            g.DrawBezier(myPen, s1, e1, e2, s2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form17()).ShowDialog();
            this.Close();
        }
    }
}
