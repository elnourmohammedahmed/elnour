using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "الصور فقط |*png;*.jpg";
            if (opd.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(opd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bp = ((Bitmap)pictureBox1.Image);
            var Ocr = new AutoOcr()
            {

                Language = IronOcr.Languages.Arabic.OcrLanguagePack,
            };
            textBox1.Text = Ocr.Read(bp).ToString();
        }
    }
}
