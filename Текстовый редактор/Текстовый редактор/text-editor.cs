using System;
using System.IO; 
using System.Windows.Forms;

namespace Текстовый_редактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt";
            
        }

        private void исправлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename,richTextBox1.Text);
            MessageBox.Show("Файл сохранен!");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            richTextBox1.Text = fileText;
            MessageBox.Show("Файл открыт!");
        }

        private void шрифтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pashalka pashal = new pashalka();
            pashal.Show();
        }
    }
}
