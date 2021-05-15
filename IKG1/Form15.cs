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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        PictureBox pb = new PictureBox();

        private void Form15_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pb);
            Form15_Paint(sender, null);
        }

        private void Form15_Paint(object sender, PaintEventArgs e)
        {
            pb.Width = 500;
            pb.Height = 500;
            Graphics g = pb.CreateGraphics();
            Image img = Image.FromFile("c:/ladya3.jpg");
            TextureBrush tBrush = new TextureBrush(img);
            Pen texturedPen = new Pen(tBrush, 100);
            //g.DrawImage(img, 0, 0, img.Width, img.Height);
            g.DrawEllipse(texturedPen, 50, 50, 250, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
