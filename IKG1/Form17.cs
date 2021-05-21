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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        PictureBox pb = new PictureBox();
        Bitmap myBitmap = new Bitmap("c:/143.png");
        Graphics g;
        Point c = new Point(350, 250);

        private void Form17_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pb);
            pb.Width = 1000;
            pb.Height = 700;
            g = pb.CreateGraphics();
            Form17_Paint(sender, null);
        }

        private void Form17_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            Rectangle r = new Rectangle(c.X - hScrollBar1.Value, 
                c.Y - hScrollBar1.Value, 2 * hScrollBar1.Value, 
                2 * hScrollBar1.Value);
            g.DrawImage(myBitmap, r);
        }

        private void hScrollBar1_Scroll(object sender, 
            ScrollEventArgs e)
        {
            Form17_Paint(sender, null);
        }
    }
}
