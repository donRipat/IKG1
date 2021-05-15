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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.ShowDialog();
            this.Close();
        }

        PictureBox mypb = new PictureBox();

        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            mypb.Width = 300;
            mypb.Height = 300;
            Graphics g = mypb.CreateGraphics();
            Brush mybr = new SolidBrush(Color.Honeydew);
            float[] angles = { 0, 130, 205, 290, 360};
            Color[] colors = {
                Color.LightGoldenrodYellow ,
                Color.PaleTurquoise,
                Color.RoyalBlue,
                Color.Purple
            };
            g.Clear(Color.Ivory);
            Rectangle r = new Rectangle(10, 50, 250, 150);
            for (int i = 1; i < angles.Length; ++i)
            {
                mybr = new SolidBrush(colors[i - 1]);
                g.FillPie(mybr, r, angles[i - 1], angles[i] - angles[i - 1]);
            }
            g.DrawEllipse(Pens.Black, r);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Controls.Add(mypb);
        }
    }
}
