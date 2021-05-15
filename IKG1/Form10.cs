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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        PictureBox mypb = new PictureBox();

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Controls.Add(mypb);
        }

        private void Form10_Paint(object sender, PaintEventArgs e)
        {
            mypb.Width = 500;
            mypb.Height = 300;
            Graphics g = mypb.CreateGraphics();
            g.Clear(Color.White);
            Rectangle MyRectangle = new Rectangle(0, 0, 200, 200);
            Pen MyPen = new Pen(Color.Red, 2);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(MyRectangle);
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterColor = Color.FromArgb(255, 255, 0, 0);
            g.DrawEllipse(MyPen, MyRectangle);
            g.FillPath(pthGrBrush, path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
