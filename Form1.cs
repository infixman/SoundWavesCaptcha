using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string txt = string.IsNullOrEmpty(textBox1.Text.Trim()) ? rnd.Next(100, 999).ToString() : textBox1.Text.Trim();
            pictureBox1.Image = Generator.Generate(txt, checkBox1.Checked);
        }
    }
}
