using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.LightGreen;
        }
        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.LightGray;
        }
        private void AboutButton_MouseEnter(object sender, EventArgs e)
        {
            AboutButton.BackColor = Color.LightGreen;
        }
        private void AboutButton_MouseLeave(object sender, EventArgs e)
        {
            AboutButton.BackColor = Color.LightGray;
        }
        private void KeyButton_MouseEnter(object sender, EventArgs e)
        {
            KeyButton.BackColor = Color.LightGreen;
        }
        private void KeyButton_MouseLeave(object sender, EventArgs e)
        {
            KeyButton.BackColor = Color.LightGray;
        }
        private void ImportButton_MouseEnter(object sender, EventArgs e)
        {
            ImportButton.BackColor = Color.LightGreen;
        }
        private void ImportButton_MouseLeave(object sender, EventArgs e)
        {
            ImportButton.BackColor = Color.LightGray;
        }
        private void ExtractButton_MouseEnter(object sender, EventArgs e)
        {
            ExtractButton.BackColor = Color.LightGreen;
        }
        private void ExtractButton_MouseLeave(object sender, EventArgs e)
        {
            ExtractButton.BackColor = Color.LightGray;
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.LightGreen;
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.LightGray;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }
        private void KeyButton_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
        }
    }
}
