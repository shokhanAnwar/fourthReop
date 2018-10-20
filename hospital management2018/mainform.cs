using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_management2018
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            textBox4.Text = DateTime.Now.ToString("yyyy/MM/dd",new System.Globalization.CultureInfo(""));
            textBox5.Text = DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo(""));
        }
    int counter=0;
    int len = 0;
    string txt;

        private void mainform_Load(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToString("hh : mm : ss .tt");
            this.ActiveControl = textBox1;
            textBox1.SelectionStart = 6;
            textBox2.SelectionStart = 6;


            txt = label3.Text;
            len = txt.Length;
            label3.Text = "";
            timer1.Start();

            label3.Parent = panel2;
            label3.BackColor = Color.Transparent;

            label3.ForeColor = Color.White;

        }

       

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("please check your username or password");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label3.Text = "";
            }
            else
            {
                label3.Text = txt.Substring(0, counter);
               
               
                    
                   
            }
        }


   
          
       

       
    }
}
