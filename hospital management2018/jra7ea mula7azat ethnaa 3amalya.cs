using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management2018
{
    public partial class jra7ea_mula7azat_ethnaa_3amalya : Form
    {
        public jra7ea_mula7azat_ethnaa_3amalya()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
            comboBox9.Enabled = true;
            comboBox10.Enabled = true;
            comboBox11.Enabled = true;
            comboBox12.Enabled = true;
            comboBox18.Enabled = true;
            comboBox17.Enabled = true;
            comboBox15.Enabled = true;
            comboBox16.Enabled = true;
            comboBox19.Enabled = true;
            comboBox20.Enabled = true;
       
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox8.Enabled = true;


            textBox6.Enabled = false;

            dateTimePicker1.Enabled = true;
            dateTimePicker4.Enabled = true;

            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;


            button4.Enabled = true;
            button5.Enabled = true;

        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox18.Enabled = false;
            comboBox17.Enabled = false;
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;
            comboBox19.Enabled = false;
            comboBox20.Enabled = false;

            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox8.Enabled = false;


            textBox6.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker4.Enabled = false;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox18.Enabled = false;
            comboBox17.Enabled = false;
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;
            comboBox19.Enabled = false;
            comboBox20.Enabled = false;

            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox8.Enabled = false;


            textBox6.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker4.Enabled = false;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;
        }
    }
}
