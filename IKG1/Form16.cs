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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        PictureBox pb = new PictureBox();

        private void Form16_Load(object sender, EventArgs e)
        {
            pb.Width = 500;
            pb.Height = 500;
            Graphics g = pb.CreateGraphics();
        }
    }
}
