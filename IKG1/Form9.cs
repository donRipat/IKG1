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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        PictureBox mypb = new PictureBox();

        private void Form9_Load(object sender, EventArgs e)
        {
            this.Controls.Add(mypb);
        }

        private void Form9_Paint(object sender, PaintEventArgs e)
        {
            mypb.Width = 500;
            mypb.Height = 300;
            Graphics g = mypb.CreateGraphics();
            GraphicsPath gp = new GraphicsPath();
            Point[] points =
            {
                new Point(15, 50),
                new Point(20, 40),
                new Point(50, 30)
            };
            FontFamily myFontFamily = new FontFamily("Comic Sans Ms");
            PointF myPointF = new PointF(50, 50);
            StringFormat myStringFormat = new StringFormat();
            gp.AddArc(0, 0, 30, 60, 30, 180);
            gp.AddCurve(points);
            gp.AddString("О сколько нам открытий...", myFontFamily, 0,
                32, myPointF, myStringFormat);
            PointF[] CurvePoints = 
            {
                new PointF(300.0F, 100.0F),
                new PointF(350.0F, 200.0F),
                new PointF(200.0F, 200.0F),
                new PointF(130.0F, 230.0F)
            };
            gp.AddPolygon(CurvePoints);
            Pen MyPen = new Pen(Color.Black, 1);
            PathGradientBrush pthGrBrush = new PathGradientBrush(gp);
            pthGrBrush.CenterColor = Color.DarkRed;
            Color[] colors = { Color.DarkViolet };
            pthGrBrush.SurroundColors = colors;
            g.FillPath(pthGrBrush, gp);
            g.DrawPath(MyPen, gp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
            this.Close();
        }
    }
}
