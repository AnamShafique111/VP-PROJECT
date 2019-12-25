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
using Xceed.Words.NET;

namespace VPProject
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Exitbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Importbutton1_Click_1(object sender, EventArgs e)
        {
            Inputpanel.Visible = false;
            if (JPGradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "jpg files|*.jpg";
                //file.Filter = "image files(*.jpg;*.jpeg)|*.jpg;*.jpeg";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName; ;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
            else if (PNGradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "png files|*.png";
                //file.Filter = "image files(*.png)|*.png";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName; ;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
            else if (PDFradioButton.Checked == true)
            {
                //string path;
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "pdf files|*.pdf";
                //file.Filter = "image files(*.pdf)|*.pdf";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    pdfDocumentViewer1.Visible = true;
                    path = file.FileName;
                    pdfDocumentViewer1.LoadFromFile(path);
                }
            }
            else if (BMPradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "bmp files|*.bmp";
                //file.Filter = "image files(*.png)|*.png";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName; ;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
            else if (TIFradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "tif files|*.tif";
                //file.Filter = "image files(*.png)|*.png";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName; ;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
            else if (radioButtonGIF.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "gif files|*.gif";
                //file.Filter = "image files(*.png)|*.png";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName; ;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
            else if (WMFradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                //file.Filter = "pcx files|*.pcx";
                file.Filter = "image files(*.wmf)|*.wmf";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName; ;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
            else if (JFIFradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                //file.Filter = "pcx files|*.pcx";
                file.Filter = "image files(*.jfif)|*.jfif";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName; ;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
            else if (EMFradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                //file.Filter = "pcx files|*.pcx";
                file.Filter = "image files(*.emf)|*.emf";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName; ;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
        }

        private void Convertbutton_Click(object sender, EventArgs e)
        {
            if (JPGradioButton.Checked == true)
            {
                Richtextboxpanel.Visible = true;
                var ocr = new AutoOcr();
                richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
            }
            else if (PNGradioButton.Checked == true)
            {
                Richtextboxpanel.Visible = true;
                var ocr = new AutoOcr();
                richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
            }
            else if (PDFradioButton.Checked == true)
            {
                Richtextboxpanel.Visible = true;
                var ocr = new AutoOcr();
                var res = ocr.ReadPdf(path);
                richTextBox.Text = res.Text.ToString();
            }
            else if (BMPradioButton.Checked == true)
            {
                Richtextboxpanel.Visible = true;
                var ocr = new AutoOcr();
                richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
            }
            else if (TIFradioButton.Checked == true)
            {
                Richtextboxpanel.Visible = true;
                var ocr = new AutoOcr();
                richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
            }
            else if (radioButtonGIF.Checked == true)
            {
                Richtextboxpanel.Visible = true;
                var ocr = new AutoOcr();
                richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
            }
            else if (WMFradioButton.Checked == true)
            {
                Richtextboxpanel.Visible = true;
                var ocr = new AutoOcr();
                richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
            }
            else if (JFIFradioButton.Checked == true)
            {
                Richtextboxpanel.Visible = true;
                var ocr = new AutoOcr();
                richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
            }
            else if (EMFradioButton.Checked == true)
            {
                Richtextboxpanel.Visible = true;
                var ocr = new AutoOcr();
                richTextBox.Text = ocr.Read(pictureBox.Image).ToString();
            }
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

        private void pdfDocumentViewer1_Click(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            Richtextboxpanel.Visible = false;
            Outputpanel.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                using (DocX document = DocX.Create("new.doc"))
                {
                    document.InsertParagraph(richTextBox.Text.ToString());
                    document.Save();
                    MessageBox.Show("File has created");
                }
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputExitbutton_Click(object sender, EventArgs e)
        {
            Outputpanel.Visible = false;
        }

        private void selectformatbutton_Click(object sender, EventArgs e)
        {
            Inputpanel.Visible = true;
        }

        private void ExitInputbutton_Click(object sender, EventArgs e)
        {
            Inputpanel.Visible = false;
        }
    }
}
