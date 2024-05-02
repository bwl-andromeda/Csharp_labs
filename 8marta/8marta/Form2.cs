using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8marta
{

    public partial class Form2 : Form
    {
        
        Random random = new Random();
        public TextBox textbox = new TextBox();
        Button[] buttons = new Button[200];
        public int cliked = 0;

        public Button Create_Button(ref Button button)
        {
            char a;
            button.Location = new Point(random.Next(0, 816), random.Next(0, 489));
            if(cliked == 0)
            {
                a = Convert.ToChar(random.Next(1040,1072));
            }
            else
            {
                a = Convert.ToChar(random.Next(1072, 1104));
            }
            button.Text = a.ToString();
            this.Controls.Add(button);

            
            return button;
        }
        public Form2()
        {
            InitializeComponent();
            for(int i = 0; i < 200; i ++)
            {
                Button button = new Button();
                button = Create_Button(ref button);
                button.Click += new System.EventHandler(this.button_Click);
                buttons[i] = button;
            }
            textbox.Text = "";
            textbox.ReadOnly = true;
            textbox.Location = new Point(random.Next(0, 816), random.Next(0, 489));
            this.Controls.Add(textbox);
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 200; i++)
            {
                if (buttons[i].Capture == true)
                {
                    textbox.Text += buttons[i].Text;
                }
            }
            cliked++;
        }
    }
}
