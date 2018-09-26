using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace hospital_management2018
{
    public partial class jra7ea_mughadarat_mstashfa : Form
    {
        public jra7ea_mughadarat_mstashfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;


            textBox6.Enabled = false;

            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;




            dateTimePicker1.Enabled = true;



            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;


            button4.Enabled = true;
            button5.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");

            textBox1.Enabled = false;
            textBox2.Enabled = false;


            textBox6.Enabled = true;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;



            dateTimePicker1.Enabled = false;



            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;


            button4.Enabled = false;
            button5.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
      

            textBox1.Enabled = false;
            textBox2.Enabled = false;


            textBox6.Enabled = true;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;



            dateTimePicker1.Enabled = false;



            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;


            button4.Enabled = false;
            button5.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
      Thread th;
      private void button6_Click(object sender, EventArgs e)
      {



          th = new Thread(backButton);
          th.SetApartmentState(ApartmentState.STA);
          th.Start();
          this.Close();
      }
        private void backButton()
        {
            Application.Run(new UserControl1().ParentForm);
        }
    }
}
