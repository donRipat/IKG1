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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        PictureBox mypb = new PictureBox();

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            mypb.Width = 300;
            mypb.Height = 300;
            Point[] points = new Point[] {
                new Point(10,100),
                new Point(75,10),
                new Point(80,50),
                new Point(100,150),
                new Point(125,80),
                new Point(175,200),
                new Point(200,80)
            };
            Graphics g = mypb.CreateGraphics();
            g.Clear(Color.White);
            Pen myPen = new Pen(Color.Red, 3);
            g.DrawBeziers(myPen, points);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Controls.Add(mypb);
        }
    }
}
