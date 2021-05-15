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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        PictureBox mypb = new PictureBox();

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Controls.Add(mypb);
        }

        private void Form8_Paint(object sender, PaintEventArgs e)
        {
            mypb.Width = 400;
            mypb.Height = 300;
            Graphics g = mypb.CreateGraphics();
            Brush mybr = new LinearGradientBrush(new Point(0, 10),
                new Point(200, 10), Color.DarkOliveGreen,
                Color.DarkOrchid);
            PointF[] pol1 =
            {
                new PointF(0,0),
                new PointF(100, 50),
                new PointF(200, 5),
                new PointF(250, 50)
            };
            PointF[] pol2 =
            {
                new PointF(300, 100),
                new PointF(350, 200),
                new PointF(200, 200),
                new PointF(130, 230)
            };
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(pol1);
            gp.AddPolygon(pol2);
            g.FillPath(mybr, gp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            this.Hide();
            form9.ShowDialog();
            this.Close();
        }
    }
}
