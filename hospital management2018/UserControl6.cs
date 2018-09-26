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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            estshrya_muraqaba ee = new estshrya_muraqaba();
            ee.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            estsharya_tarexMartha et = new estsharya_tarexMartha();
            et.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estsharya_3elaj e3 = new estsharya_3elaj();
            e3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            estsharya_mulahazat_tamrezi em = new estsharya_mulahazat_tamrezi();
            em.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            estsharaya_mughadarat emu = new estsharaya_mughadarat();
            emu.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true; 
            comboBox10.Enabled = true;
            comboBox11.Enabled = true;
            comboBox12.Enabled = true;        
            comboBox15.Enabled = true;
            comboBox16.Enabled = true;
            comboBox17.Enabled = true;       
            comboBox25.Enabled = true;
          
            textBox3.Enabled = true;
            textBox6.Enabled = false;
          
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;
            dateTimePicker4.Enabled = true;
            dateTimePicker5.Enabled = true;
            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;
            dateTimePicker8.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;
            comboBox17.Enabled = false;
            comboBox25.Enabled = false;

            textBox3.Enabled = false;
            textBox6.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;
            dateTimePicker8.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;
            comboBox17.Enabled = false;
            comboBox25.Enabled = false;

            textBox3.Enabled = false;
            textBox6.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;
            dateTimePicker8.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }
    }
}
