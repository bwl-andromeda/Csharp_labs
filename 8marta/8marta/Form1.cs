using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8marta
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int min_day = 1, max_day = 31;
        int min_month = 1, max_month = 12;
        int min_year = -10000, max_year = 10000;
        Form2 form2 = new Form2();

        int day = 0, month = 0, year = 0;

        bool flag = true;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = -1000; trackBar1.Maximum = 1000;
            trackBar1.LargeChange = 1;
            day = random.Next(min_day, max_day + 1);
            month = random.Next(min_month, max_month + 1);
            year = random.Next(min_year, max_year + 1);
            textBox1.Text = Convert.ToString(day) + ". " + Convert.ToString(month) + ". " + Convert.ToString(year);
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            Second_Name.Text += domainUpDown2.Text;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(trackBar1.Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            min_day = 1;
            max_day = 31;
            min_month = 1;
            max_month = 12;
            min_year = -10000;
            max_year = 10000;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            //
            //Саша
            //
            if (true || domainUpDown1.Text == "Александра")
                if (true || Second_Name.Text == "МИХАЙЛОВА")
                    if (true || textBox3.Text == "НИКОЛАЕВНА")
                        if (true || day == 26 & month == 11 & year == 2004)
                            if (true || textBox2.Text == "4")
                                MessageBox.Show("ВЫ ПОБЕДИЛИ!!!\nПокажите это сообщение чтоб получить подарок");
                            else
                                MessageBox.Show("Поздравляю, вы не победили!");
                        else
                            MessageBox.Show("Забыла, когда из мамы вышла? Вспоминай!");
                    else
                        MessageBox.Show("У нас нет девочки с таким отчеством. Ну ты че?!");
                else
                    MessageBox.Show("У нас нет девочки с такой фамилией. Go again");
           
            //
            //Настя
            //
            else if (domainUpDown1.Text == "Анастасия")
                if (Second_Name.Text == "ВАСЬКИНА")
                    if (textBox3.Text == "ДМИТРИЕВНА")
                        if (day == 19 & month == 2 & year == 2004)
                            if (textBox2.Text == "4")
                                MessageBox.Show("ВЫ ПОБЕДИЛИ!!!\nПокажите это сообщение чтоб получить подарок");
                            else
                                MessageBox.Show("Поздравляю, вы не победили!");
                        else
                            MessageBox.Show("Забыла, когда из мамы вышла? Вспоминай!");
                    else
                        MessageBox.Show("У нас нет девочки с таким отчеством. Ну ты че?!");
                else
                    MessageBox.Show("У нас нет девочки с такой фамилией. Go again");
            //
            //Николь
            //
            else if (domainUpDown1.Text == "Николь")
                if (Second_Name.Text == "ТИХОНОВА")
                    if (textBox3.Text == "АНДРЕЕВНА")
                        if (day == 17 & month == 9 & year == 2004)
                            if (textBox2.Text == "4")
                                MessageBox.Show("ВЫ ПОБЕДИЛИ!!!\nПокажите это сообщение чтоб получить подарок");
                            else
                                MessageBox.Show("Поздравляю, вы не победили!");
                        else
                            MessageBox.Show("Забыла, когда из мамы вышла? Вспоминай!");
                    else
                        MessageBox.Show("У нас нет девочки с таким отчеством. Ну ты че?!");
                else
                    MessageBox.Show("У нас нет девочки с такой фамилией. Go again");
            //
            //Юля
            //
            else if (domainUpDown1.Text == "Юлия")
                if (Second_Name.Text == "ФИЛИППОВА")
                    if (textBox3.Text == "ВЛАДИСЛАВОВНА")
                        if (day == 10 & month == 8 & year == 2004)
                            if (textBox2.Text == "4")
                                MessageBox.Show("ВЫ ПОБЕДИЛИ!!!\nПокажите это сообщение чтоб получить подарок");
                            else
                                MessageBox.Show("Поздравляю, вы не победили!");
                        else
                            MessageBox.Show("Забыла, когда из мамы вышла? Вспоминай!");
                    else
                        MessageBox.Show("У нас нет девочки с таким отчеством. Ну ты че?!");
                else
                    MessageBox.Show("У нас нет девочки с такой фамилией. Go again");
            else
                MessageBox.Show("У нас нет девочки с таким именем. Try Again");
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            form2.textbox.Text = "";
            form2.ShowDialog();
            textBox3.Text += form2.textbox.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            form2.cliked = 0;
            form2.textbox.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Second_Name.Text.Length > 0)
                Second_Name.Text = Second_Name.Text.Remove(Second_Name.Text.Length - 1, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (min_year != max_year)
            {
                max_year = year;
            }
            else if (min_month != max_month)
            {
                max_month = month;
            }
            else if (min_day != max_day)
            {
                max_day = day;
            }
            day = random.Next(min_day, max_day + 1);
            month = random.Next(min_month, max_month + 1);
            year = random.Next(min_year, max_year + 1);
            textBox1.Text = Convert.ToString(day) + ". " + Convert.ToString(month) + ". " + Convert.ToString(year);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (min_year != max_year)
            {
                min_year = year;
            }
            else if (min_month != max_month)
            {
                min_month = month;
            }
            else if (min_day != max_day)
            {
                min_day = day;
            }
            day = random.Next(min_day, max_day + 1);
            month = random.Next(min_month, max_month + 1);
            year = random.Next(min_year, max_year + 1);
            textBox1.Text = Convert.ToString(day) + ". " + Convert.ToString(month) + ". " + Convert.ToString(year);
        }
    }
}
