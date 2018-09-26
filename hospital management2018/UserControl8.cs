using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management2018
{
    public partial class UserControl8 : UserControl
    {
        public UserControl8()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void UserControl8_Load(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            wa7dat_7sabat ww = new wa7dat_7sabat();
            ww.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            comboBox1.Enabled = true;

            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
     

            textBox1.Enabled = true;
            textBox2.Enabled = true;



            textBox6.Enabled = false;   

            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;

            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;

            numericUpDown1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;

            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;


            textBox1.Enabled = false;
            textBox2.Enabled = false;



            textBox6.Enabled = true;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;

            button2.Enabled = false;
            button3.Enabled = false;

            numericUpDown1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;

            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;


            textBox1.Enabled = false;
            textBox2.Enabled = false;



            textBox6.Enabled = true;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;

            button2.Enabled = false;
            button3.Enabled = false;

            numericUpDown1.Enabled = false;
        }
    }
}
