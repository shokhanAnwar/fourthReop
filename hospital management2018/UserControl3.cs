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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            comboBox2.Enabled = true;       
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
            comboBox9.Enabled = true;
            comboBox10.Enabled = true;
            comboBox11.Enabled = true;
            comboBox12.Enabled = true;
            comboBox13.Enabled = true;
            comboBox14.Enabled = true;
            comboBox15.Enabled = true;
          
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox19.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox17.Enabled = true;
            textBox18.Enabled = true;
            textBox22.Enabled = true;

            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;
            dateTimePicker4.Enabled = true;
            dateTimePicker5.Enabled = true;
            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;
            dateTimePicker8.Enabled = true;
            dateTimePicker9.Enabled = true;
            dateTimePicker10.Enabled = true;
            dateTimePicker11.Enabled = false;
            dateTimePicker12.Enabled = false;

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

            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;
            comboBox15.Enabled = false;

            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox19.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox22.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;
            dateTimePicker8.Enabled = false;
            dateTimePicker9.Enabled = false;
            dateTimePicker10.Enabled = false;
            dateTimePicker11.Enabled = true;
            dateTimePicker12.Enabled = true;

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

            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;
            comboBox15.Enabled = false;

            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox19.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox22.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;
            dateTimePicker8.Enabled = false;
            dateTimePicker9.Enabled = false;
            dateTimePicker10.Enabled = false;
            dateTimePicker11.Enabled = true;
            dateTimePicker12.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button4.Enabled = false;
            button5.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
