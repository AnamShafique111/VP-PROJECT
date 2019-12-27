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
using PdfSharp.Pdf;

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
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
            else if (PDFradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "pdf files|*.pdf";
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
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
            else if (TIFradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "tif files|*.tif";
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
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = file.FileName; ;
                    pictureBox.ImageLocation = textBox1.Text;
                }
            }
           
            else if (JFIFradioButton.Checked == true)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "image files(*.jfif)|*.jfif";
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
            else if (JFIFradioButton.Checked == true)
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
            if (WordradioButton.Checked == true)
            {
                SaveFileDialog word = new SaveFileDialog();
                word.DefaultExt = "*.doc";
                word.Filter = "DOC files|*.doc";
                {
                    if (word.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox.SaveFile(word.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("File has created");
                    }
                }
            }
            //else if (radioButtonPDF.Checked == true)
            //{
            //    SaveFileDialog pdf = new SaveFileDialog();
            //    pdf.DefaultExt = "*.pdf";
            //    pdf.Filter = "PDF files|*.pdf";
            //    {
            //        if (pdf.ShowDialog() == DialogResult.OK)
            //        {
            //            richTextBox.SaveFile(pdf.FileName, RichTextBoxStreamType.PlainText);
            //            MessageBox.Show("File has created");
            //        }
            //    }
            //}
            else if (RTFradioButton.Checked == true)
            {
                SaveFileDialog rtf = new SaveFileDialog();
                rtf.DefaultExt = "*.rtf";
                rtf.Filter = "RTF files|*.rtf";
                {
                    if (rtf.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox.SaveFile(rtf.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("File has created");
                    }
                }
            }
            else if (TextradioButton.Checked == true)
            {
                SaveFileDialog txt = new SaveFileDialog();
                txt.DefaultExt = "*.txt";
                txt.Filter = "TXT files|*.txt";
                {
                    if (txt.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox.SaveFile(txt.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("File has created");
                    }
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pdfDocumentViewer1.Visible=false;
        }

        
    }
}
