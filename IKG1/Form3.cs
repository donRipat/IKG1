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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        PictureBox mypb = new PictureBox();

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            mypb.Width = 300;
            mypb.Height = 300;
            this.Controls.Add(mypb);
            Point s1 = new Point(10, 100);
            Point e1 = new Point(100, 10);
            Point e2 = new Point(150, 150);
            Point s2 = new Point(200, 100);
            Graphics g = mypb.CreateGraphics();
            g.Clear(Color.White);
            Pen myPen = new Pen(Color.Black, 3);
            g.DrawBezier(myPen, s1, e1, e2, s2);
        }
    }
}
