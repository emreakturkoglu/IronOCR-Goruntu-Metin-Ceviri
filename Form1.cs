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

namespace OCR_tarama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap image = new Bitmap("deneme.jpg");
        private void Dosyasec(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                image = new Bitmap(file.FileName);
                pictureBox1.Image = image;
            }

        }

        private void ocrdonusum(object sender, EventArgs e)
        {
            var ocr = new AutoOcr();
            ocr_text.Text=ocr.Read(image).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            OpenFileDialog pdf = new OpenFileDialog();
            pdf.ShowDialog();

        }

        private void ocr_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
