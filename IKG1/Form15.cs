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
        Image img = Image.FromFile("c:/ladya3.jpg");
        Graphics g;

        private void Form15_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pb);
            pb.Width = 500;
            pb.Height = 500;
            g = pb.CreateGraphics();
            Form15_Paint(sender, null);
        }

        private void Form15_Paint(object sender, PaintEventArgs e)
        {
            TextureBrush tBrush = new TextureBrush(img);
            Pen texturedPen = new Pen(tBrush, 100);
            //g.DrawImage(img, 0, 0, img.Width, img.Height);
            g.DrawEllipse(texturedPen, 50, 50, 250, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 f = new Form16();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
