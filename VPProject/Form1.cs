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
using System.IO;

namespace VPProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Importbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = file.FileName; ;
                pictureBox.ImageLocation = textBox1.Text;
            }
        }

        private void Exitbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Convertbutton_Click(object sender, EventArgs e)
        {
            Richtextboxpanel.Visible = true;
            var ocr = new AutoOcr();
            richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
        }

        private void Exitbutton2_Click(object sender, EventArgs e)
        {
            Richtextboxpanel.Visible = false;
        }

        private void Exitbutton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string path;
        private void pdfImportbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "pdf files|*.pdf";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pdfDocumentViewer1.Visible = true;
                path = file.FileName;
                pdfDocumentViewer1.LoadFromFile(path);

                //axAcroPDF1.Visible = true;
                //axAcroPDF1.LoadFile(path);
            }
        }
        private void PdfConvertbutton_Click(object sender, EventArgs e)
        {
            Richtextboxpanel.Visible = true;
            var ocr = new AutoOcr();
            var res = ocr.ReadPdf(path);
            richTextBox.Text = res.Text.ToString();
            //richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
        }

        private void pdfDocumentViewer1_Click(object sender, EventArgs e)
        {

        }
    }
}
