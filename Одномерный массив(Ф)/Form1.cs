using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Одномерный_массив_Ф_
{
    public partial class Form1 : Form
    {
        int n;
        int count, result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox3.Text);
            int[] array = new int[n];
            string s = textBox1.Text;
            string[] s_1 = s.Split(' ');
            if (s_1.Length == n)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = Convert.ToInt32(s_1[i]);
                }
            }
            else
            {
                MessageBox.Show("Количество элементов в строке не соответствует размеру массива!");
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    count += 1;
                    if (result < count)
                    {
                        result = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            string result_2 = Convert.ToString(result + 1);
            textBox2.Text = result_2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
