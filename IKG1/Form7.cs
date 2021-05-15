using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKG1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        PictureBox mypb = new PictureBox();
        
        private void Form7_Load(object sender, EventArgs e)
        {
            this.Controls.Add(mypb);
        }

        private void Form7_Paint(object sender, PaintEventArgs e)
        {
            mypb.Width = 400;
            mypb.Height = 300;
            Graphics g = mypb.CreateGraphics();
            Brush mybr = new HatchBrush(HatchStyle.DarkUpwardDiagonal,
                Color.DarkGoldenrod, Color.Crimson);
            PointF[] pol =
            {
                new PointF(0,0),
                new PointF(100, 25),
                new PointF(200, 5),
                new PointF(250, 50),
                new PointF(300, 100),
                new PointF(350, 200),
                new PointF(200, 200),
                new PointF(130, 230)
            };
            g.FillPolygon(mybr, pol, FillMode.Winding);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.ShowDialog();
            this.Close();
        }
    }
}
