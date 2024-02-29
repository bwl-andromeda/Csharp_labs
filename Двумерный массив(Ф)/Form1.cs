using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Двумерный_массив_Ф_
{
    public partial class Form1 : Form
    {
        float[,] matrix = new float[50, 50];
        int rows, cols;

        public void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                float sumP = 0;
                float productN = 1;

                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = Convert.ToSingle(dataGridView1.Rows[i].Cells[j].Value);
                    if (matrix[i,j] > 0)
                    {
                        sumP += matrix[i, j];
                    }
                    else if (matrix[i,j] < 0)
                    {
                        productN *= matrix[i,j];
                    }
                }
                MessageBox.Show($"Сумма положительных элементов в строке {i + 1}: {sumP}");
                MessageBox.Show($"Произведение отрицательных элементов в строке {i + 1}: {productN}");
            }

        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != " ")
            {
                rows = int.Parse(textBox2.Text);
                cols = int.Parse(textBox1.Text);
                dataGridView1.RowCount = rows;
                dataGridView1.ColumnCount = cols;
            }
            else
            {
                MessageBox.Show("Заполните данные");
            }

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
