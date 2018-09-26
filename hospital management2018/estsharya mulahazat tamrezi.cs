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
    public partial class estsharya_mulahazat_tamrezi : Form
    {
        public estsharya_mulahazat_tamrezi()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true; 
            comboBox7.Enabled = true;
           

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox7.Enabled = true;
            textBox12.Enabled = true;
            textBox14.Enabled = true;
            textBox9.Enabled = true;           
            textBox8.Enabled = true;
            textBox11.Enabled = true;
            textBox13.Enabled = true;

            textBox6.Enabled = false;

            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;
            dateTimePicker4.Enabled = true;
            dateTimePicker5.Enabled = true;
            dateTimePicker8.Enabled = true;
            dateTimePicker9.Enabled = true;
            dateTimePicker10.Enabled = true;
            dateTimePicker11.Enabled = true;
            dateTimePicker12.Enabled = true;

            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;


            button4.Enabled = true;
            button5.Enabled = true;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox7.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox7.Enabled = false;
            textBox12.Enabled = false;
            textBox14.Enabled = false;
            textBox9.Enabled = false;
            textBox8.Enabled = false;
            textBox11.Enabled = false;
            textBox13.Enabled = false;

            textBox6.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker8.Enabled = false;
            dateTimePicker9.Enabled = false;
            dateTimePicker10.Enabled = false;
            dateTimePicker11.Enabled = false;
            dateTimePicker12.Enabled = false;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox7.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox7.Enabled = false;
            textBox12.Enabled = false;
            textBox14.Enabled = false;
            textBox9.Enabled = false;
            textBox8.Enabled = false;
            textBox11.Enabled = false;
            textBox13.Enabled = false;

            textBox6.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker8.Enabled = false;
            dateTimePicker9.Enabled = false;
            dateTimePicker10.Enabled = false;
            dateTimePicker11.Enabled = false;
            dateTimePicker12.Enabled = false;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
