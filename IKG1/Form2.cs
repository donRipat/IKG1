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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        PictureBox mypb = new PictureBox();

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            mypb.Height = 300;
            mypb.Width = 300;
            Graphics g = mypb.CreateGraphics();
            Rectangle myBox = new Rectangle(5, 10, 150, 200);
            Pen myPen = new Pen(Color.Blue, 2);
            g.DrawEllipse(myPen, myBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Controls.Add(mypb);
        }
    }
}
