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
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }

        private void UserControl7_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox4.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
            comboBox9.Enabled = true;
            comboBox10.Enabled = true;
            comboBox11.Enabled = true;
            comboBox12.Enabled = true;
            comboBox13.Enabled = true;
            comboBox14.Enabled = true;

            comboBox22.Enabled = true;


            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox7.Enabled = true;

            textBox6.Enabled = false;
            textBox8.Enabled = true;


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;

            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;
            comboBox4.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;

            comboBox22.Enabled = false;


            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox7.Enabled = false;

            textBox6.Enabled = true;
            textBox8.Enabled = false;


            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox4.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;

            comboBox22.Enabled = false;


            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox7.Enabled = false;

            textBox6.Enabled = true;
            textBox8.Enabled = false;


            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            jra7ea_dxul_martha jj = new jra7ea_dxul_martha();
            jj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            jra7ea_mula7zat_tamrezi tt = new jra7ea_mula7zat_tamrezi();
            tt.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            jra7ea_mutaba3a_ser_marath ss = new jra7ea_mutaba3a_ser_marath();
            ss.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            jra7ea_mughadarat_mstashfa jj = new jra7ea_mughadarat_mstashfa();
            jj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            jra7ea_mareth_raqd rr = new jra7ea_mareth_raqd();
            rr.Show();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            jra7ea_fa7s_sareri_qabl_3amalya ff = new jra7ea_fa7s_sareri_qabl_3amalya();
            ff.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            jra7ea_mula7azat_ethnaa_3amalya th = new jra7ea_mula7azat_ethnaa_3amalya();
            th.Show();
        }
    }
}